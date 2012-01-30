using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension.Helpers;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using Fluqi.Core.Interfaces;
using System.IO;

namespace Fluqi.Widget.jAccordion
{
	public partial class Accordion: Core.ControlBase, IDisposable, IScriptRenderer, Core.Interfaces.IControl {

		/// <summary>
		/// Flags the Accordion has been disposed.
		/// </summary>
		protected internal bool _Disposed;

		/// <summary>
		/// Holds the Panels of the Accordion.
		/// </summary>
		protected internal Panels _Panels = null;

		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the Accordion control, this is "accordion".
		/// </remarks>
		public string PlugInName { get; protected internal set; }

		/// <summary>
		/// ID of the jQuery UI Tabs object.  Must be unique on the page.
		/// </summary>
		public string ID { get; protected internal set; }

		/// <summary>
		/// Response object to write the control to.
		/// </summary>
		public TextWriter Writer { get; protected internal set; }

		/// <summary>
		/// Specifies the options to be adopted for this set of Accordion (see <see cref="Options"/> class
		/// for full details)
		/// </summary>
		public Options Options { get; protected internal set; }

		/// <summary>
		/// Specifies the events to be adopted for this set of Accordion (see <see cref="Events"/> class
		/// for full details)
		/// </summary>
		public Events Events { get; protected internal set; }

		/// <summary>
		/// Specifies the Methods object that can be used to interact with the control.
		/// </summary>
		public Methods Methods { get; protected internal set; }

		/// <summary>
		/// Specifies the settings to be adopted when rendering the control (e.g. whether to compress the JavaScript, 
		/// include jQuery UI class names, etc.
		/// </summary>
		public Rendering Rendering { get; protected internal set; }

		/// <summary>
		/// Returns the list of Panels added to the Accordion control.
		/// </summary>
		public Panels Panels { 
			get {
				return _Panels;
			}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="writer">Response object to write to</param>
		/// <param name="id">ID of the accordion, this must be unique for the page</param>
		public Accordion(TextWriter writer, string id)
			: this(writer, id, "")
		{
		}


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="writer">Response object to write to</param>
		/// <param name="id">ID of the tabs collection, this must be unique for the page</param>
		/// <param name="headingTag">Heading tag to be used (by default this is H3)</param>
		public Accordion(TextWriter writer, string id, string headingTag) {
			this.PlugInName = "accordion";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
			if (!string.IsNullOrEmpty(headingTag))
				this.Options.HeadingTag = headingTag;
			this._Panels = new Panels(this);
		}


		/// <summary>
		/// Renders the tab headers
		/// </summary>
		public Accordion RenderContainer() {
			return this.BeginAccordion();
		}


		/// <summary>
		/// Renders the tab heading (where each tab is laid out horizontally).
		/// </summary>
		/// <remarks>
		/// Note all the class information is also output to maintain styling for non-JavaScript users.
		/// </remarks>
		/// <returns>Returns Accordion object to maintain chainability</returns>
		protected Accordion BeginAccordion() {
			_Panels.ResetPaneIndex();
			string containerHtml = this.GetTagHtml();

			Writer.Write(containerHtml);

			return this;
		}


		/// <summary>
		/// Builds up the opening HTML for the Accordion control.
		/// </summary>
		/// <returns>Opening HTML</returns>
		/// <remarks>
		/// Only renders the opening part as we need to allow the HTML in the "using" block 
		/// to be rendered out and then close off).
		/// </remarks>
		protected string GetTagHtml() {
			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);
			
			_Panels.ResetPaneIndex();

			// Work out if we have an accordion set as the active one
			_Panels.ResolveActivePane();

			if (renderCss) {
				this.WithCss("ui-accordion ui-widget ui-helper-reset ui-accordion-icons");
			}
			base.WithID(this.ID);

			sb.Append("<div");
			base.RenderAttributes(sb);
			sb.Append(">");

			return sb.ToString();
		}


		/// <summary>
		/// Writes out the initialisation JavaScript to configure the tabs object client-side.
		/// </summary>
		/// <remarks>
		/// Useful if you want to declare your own document.ready and add in the initialisation
		/// yourself (if you have additional initialisation you want to perform for instance).
		/// </remarks>
		protected internal string GetControlScript(int tabDepth) {
			jStringBuilder sb = new jStringBuilder(this.Rendering.PrettyRender, this.Rendering.TabDepth);
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$(\"#{0}\").accordion(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			sb.DecIndent();

			return sb.ToString();
		}


		/// <summary>
		/// Writes the closing part of the Tabs layout (i.e. the closing DIV tag).
		/// Also writes out the document.ready and tabs initialisation JavaScript 
		/// </summary>
		protected internal void EndAccordion() {
			bool prettyRender = this.Rendering.PrettyRender;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Closing Accordion DIV
			sb.AppendLineIf();
			sb.AppendTabsLineIf("</div>");

			this.Writer.Write(sb.ToString());

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}

		} // EndAccordion


		/// <summary>
		/// Forces the closing DIV tag to be output after a Tabs "using" block has completed.
		/// </summary>
		protected virtual void Dispose(bool disposing) {
			if (!this._Disposed) {
				this._Disposed = true;
				EndAccordion();
			}
		}


#pragma warning disable 1591
		[SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
		public void Dispose() {
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}
#pragma warning restore 1591

	} // Accordion
}
