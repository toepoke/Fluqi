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

namespace Fluqi.Widget.jProgressBar
{
	public partial class ProgressBar: Core.ControlBase, IControlRenderer, IScriptRenderer, Core.Interfaces.IControl
	{
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the ProgressBar control, this is "progressbar".
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
		/// Specifies the events to be adopted for the control(see <see cref="Events"/> class
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
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		/// <param name="id">ID of the control (which must be unique on the page)</param>
		public ProgressBar(TextWriter writer, string id) {
			this.PlugInName = "progressbar";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
		}

		/// <summary>
		/// Builds the HTML required to render the ProgressBar control (the DIV basically).
		/// </summary>
		/// <returns>Returns this HTML for the ProgressBar</returns>
		protected internal string GetTagHtml() {
			// ID property is _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("ProgressBar ID property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			sb.AppendTabsIf();
			sb.Append("<div");
			this.WithID(this.ID);

			if (renderCss) 
				this.WithCss("ui-progressbar ui-widget ui-widget-content ui-corner-all");
			
			base.RenderAttributes(sb);
				
			sb.Append("></div>");

			return sb.ToString();
		}
		

		/// <summary>
		/// Writes the HTML for the ProgressBar to the response stream.
		/// JavaScript initialisation for the control is also added to the response stream if the
		/// AutoScript rendering option is true.
		/// </summary>
		public void Render() {
			string tagHTML = this.GetTagHtml();
			Writer.Write(tagHTML);

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}
		}


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
			sb.AppendTabsFormatIf("$(\"#{0}\").progressbar(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			sb.DecIndent();
			
			return sb.ToString();
		}

	}
}
