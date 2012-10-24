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
using System.IO;
using Fluqi.Core.Interfaces;

namespace Fluqi.Widget.jTab
{
	public partial class Tabs: Core.ControlBase, IScriptRenderer, IDisposable, Core.Interfaces.IControl
	{
		/// <summary>
		/// Flags that the Tabs object has been disposed.
		/// </summary>
		protected internal bool _Disposed;

		/// <summary>
		/// Holds the set of Panes the Tabs object has.
		/// </summary>
		protected internal Panes _Panes = null;

		/// <summary>
		/// Flags the Tabs container (the tab headings) has been rendered.
		/// </summary>
		protected internal bool _HeaderRendered = false;

		/// <summary>
		/// Flags that any Panels added to the Tabs control are to be added as dynamic panes.
		/// </summary>
		protected internal bool _AsDynamic = false;
		
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the Tabs control, this is "tabs".
		/// </remarks>
		public string PlugInName { get; protected internal set; }

		/// <summary>
		/// ID of the jQuery UI Tabs object.  Must be unique on the page.
		/// </summary>
		public string ID { get; protected internal set; }

		/// <summary>
		/// Specifies the options to be adopted for this set of Tabs (see <see cref="Options"/> class
		/// for full details)
		/// </summary>
		public Options Options { get; protected internal set; }

		/// <summary>
		/// Specifies the events to be adopted for the control (see <see cref="Events"/> class
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
		/// Response object to write control data to.
		/// </summary>
		public TextWriter Writer { get; protected internal set; }

		/// <summary>
		/// Returns the Dictionary of tab Panes added to the Tabs control.
		/// </summary>
		 public Panes Panes { 
			get {
				return _Panes;
			}
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="writer">Response object to write to</param>
		/// <param name="id">ID of the tabs collection, this must be unique for the page</param>
		public Tabs(TextWriter writer, string id) {
			this.PlugInName = "tabs";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
			this._Panes = new Panes(this);
		}


		/// <summary>
		/// Flags that the tabs are to be loaded dynamically from the server.  
		/// </summary>
		/// <returns>Returns <see cref="Panes"/> object to return chaining to the Tabs collection</returns>
		/// <remarks>
		/// Note that when loading the tabs dynamically no containers are rendered (yes NONE of them), 
		/// indeed calling "RenderHeader" on a Pane with the Dynamic setting on _will_ cause an exception.
		/// </remarks>
		public Tabs AsDynamic() {
			_AsDynamic = true;
			return this;
		}

	
		/// <summary>
		/// Renders the tab headers
		/// </summary>
		public Tabs RenderHeader() {
			return this.BeginTabs();
		}


		/// <summary>
		/// Builds and returns the HTML required for the opening of the Tabs control.
		/// </summary>
		/// <returns>HTML for the opening of the tabs control.</returns>
		protected internal string GetTagHtml() {
			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Work out if we have an active tab set, if not default to the first one
			if (!this.Panes.HasActiveTab() && _Panes._Panes.Any())
				_Panes._Panes.Values.FirstOrDefault().IsActive = true;
			
			if (renderCss) {
				this.WithCss("ui-tabs ui-widget ui-widget-content ui-corner-all");
			}
			this.WithID(this.ID);

			sb.Append("<div");
			this.RenderAttributes(sb);
			sb.AppendLineIf(">");

			// Open Tabs header
			sb.IncIndent();
			if (renderCss)
				sb.AppendTabsFormatLineIf("<ul class=\"ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all\">");
			else 
				sb.AppendTabsLineIf("<ul>");

			// Have each tab render it's Header link
			_HeaderRendered = true;	// main header rendered
			sb.IncIndent();
			foreach (Pane tb in _Panes._Panes.Values) {
				tb.RenderHeader(sb);
			} 
			
			// Close Tabs header
			sb.DecIndent();
			sb.AppendTabsLineIf("</ul>");		
			
			// Finally prep for iterating over the tabs
			this.Panes.ResetEnumerator();

			return sb.ToString();
		}

		/// <summary>
		/// Renders the tab heading (where each tab is laid out horizontally).
		/// </summary>
		/// <remarks>
		/// Note all the class information is also output to maintain styling for non-JavaScript users.
		/// </remarks>
		/// <returns>Returns Tabs object to maintain chainability</returns>
		protected Tabs BeginTabs() {
			this.Panes.ResetEnumerator();
			_HeaderRendered = false;
			
			string tagHtml = GetTagHtml();

			Writer.Write(tagHtml.ToString());

			return this;
		}


		/// <summary>
		/// Writes the closing part of the Tabs layout (i.e. the closing DIV tag).
		/// Also writes out the document.ready and tabs initialisation JavaScript (if so defined).
		/// </summary>
		protected internal void EndTabs() {
			bool prettyRender = this.Rendering.PrettyRender;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Closing Tabs DIV
			sb.AppendTabsLineIf("</div>");

			this.Writer.Write(sb.ToString());

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}
		}


		/// <summary>
		/// Writes out the calling script for the jQuery Tabs plugin, adding options that have been
		/// a defined.
		/// </summary>
		/// <param name="tabDepth">
		/// How far to indent the script code setting.
		/// </param>
		/// <returns>
		/// Returns rendered initialisation script
		/// </returns>
		public string GetControlScript(int tabDepth) {
			jStringBuilder sb = new jStringBuilder(this.Rendering.PrettyRender, this.Rendering.TabDepth);
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$(\"#{0}\").tabs(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			sb.DecIndent();
			
			return sb.ToString();
		}
		

		/// <summary>
		/// Forces the closing DIV tag to be output after a Tabs "using" block has completed.
		/// </summary>
		protected virtual void Dispose(bool disposing) {
			if (!this._Disposed)
			{
				this._Disposed = true;
				EndTabs();
			}
		}


#pragma warning disable 1591
		[SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
		public void Dispose() {
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}
#pragma warning restore 1591

	} // Tabs
}
