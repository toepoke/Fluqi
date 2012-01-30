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

namespace Fluqi.Widget.jDialog
{
	public partial class Dialog: Core.ControlBase, IScriptRenderer, IDisposable, IControl
	{
		/// <summary>
		/// Flags dialog has been disposed.
		/// </summary>
		protected internal bool _Disposed = false;

		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the Dialog control, this is "dialog".
		/// </remarks>
		public string PlugInName { get; protected internal set; }

		/// <summary>
		/// ID of the jQuery UI object.  Must be unique on the page.
		/// </summary>
		public string ID { get; protected internal set; }

		/// <summary>
		/// Response object to write the control to.
		/// </summary>
		public TextWriter Writer { get; protected internal set; }

		/// <summary>
		/// Specifies the options to be adopted for this object (see <see cref="Options"/> class
		/// for full details)
		/// </summary>
		public Options Options { get; protected internal set; }

		/// <summary>
		/// Specifies the events to be adopted for this control (see <see cref="Events"/> class
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
		/// Constructor
		/// </summary>
		/// <param name="writer">Response stream to write the Dialog to</param>
		/// <param name="id">ID of the control (which must be unique on the page)</param>
		public Dialog(TextWriter writer, string id) {
			this.PlugInName = "dialog";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
		}


		/// <summary>
		/// Writes the opening HTML for the Dialog to the response stream.
		/// </summary>
		/// <returns>this for chainability</returns>
		public Dialog RenderDialog() {
			return this.BeginDialog();
		}


		/// <summary>
		/// Writes the opening HTML for the Dialog to the response stream.
		/// </summary>
		/// <returns>this for chainability</returns>
		protected Dialog BeginDialog() {
			string html = this.GetTagHtml();

			Writer.Write(html);

			return this;
		}


		/// <summary>
		/// Builds and returns the HTML for the opening part of the Dialog control (opening as we have
		/// to separate the closing so we can have the Dialog conten written to the response stream).
		/// </summary>
		/// <returns>Opening HTML for the dialog</returns>
		protected internal string GetTagHtml() {
			// ID property is _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("Dialog ID property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			sb.AppendTabsIf();
			sb.Append("<div");
			this.WithID(this.ID);

			if (renderCss) 
				this.WithCss("ui-dialog-content ui-widget-content");

			this.RenderAttributes(sb);
							
			sb.Append(">"); //</div>");

			return sb.ToString();
		}
		

		/// <summary>
		/// Writes the closing part of the Dialog HTML to the response stream (basically the closing div).
		/// </summary>
		protected internal void EndDialog() {
			bool prettyRender = this.Rendering.PrettyRender;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			// Closing dialog DIV
			sb.AppendLineIf();
			sb.AppendTabsLineIf("</div>");

			Writer.Write(sb.ToString());

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}

		} // EndDialog


		/// <summary>
		/// Writes out the initialisation JavaScript to configure the tabs object client-side.
		/// </summary>
		/// <remarks>
		/// Useful if you want to declare your own document.ready and add in the initialisation
		/// yourself (if you have additional initialisation you want to perform for instance).
		/// </remarks>
		protected internal string GetControlScript() {
			return this.GetControlScript(this.Rendering.TabDepth);
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
		protected internal string GetControlScript(int tabDepth) {
			jStringBuilder sb = new jStringBuilder(this.Rendering.PrettyRender, this.Rendering.TabDepth);
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$(\"#{0}\").dialog(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			sb.DecIndent();
			
			return sb.ToString();
		}


		/// <summary>
		/// Writes the closing part of the Dialog to the response stream (i.e. the "using" block is being
		/// closed).
		/// </summary>
		protected virtual void Dispose(bool disposing) {
			if (!this._Disposed) {
				EndDialog();
				this._Disposed = true;
			}
		}

		
#pragma warning disable 1591
		[SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
		public void Dispose()
		{
			Dispose(true /* disposing */);
			GC.SuppressFinalize(this);
		}
#pragma warning restore 1591

	}
}
