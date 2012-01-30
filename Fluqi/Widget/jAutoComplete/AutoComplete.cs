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

namespace Fluqi.Widget.jAutoComplete
{
	
	public partial class AutoComplete: Core.ControlBase, IControlRenderer, IScriptRenderer, Core.Interfaces.IControl
	{
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the AutoComplete control, this is "autocomplete".
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
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		/// <param name="source">
		/// Source for the AutoComplete to resolve items from, which could be a JavaScript array,
		/// a JavaScript callback function, a URL, etc.
		/// </param>	
		public AutoComplete(TextWriter writer, string source)
			: this(writer, "", source) 
		{ }
		

		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		/// <param name="id">ID of the control (which must be unique on the page)</param>
		/// <param name="source">
		/// Source for the AutoComplete to resolve items from, which could be a JavaScript array,
		/// a JavaScript callback function, a URL, etc.
		/// </param>	
		public AutoComplete(TextWriter writer, string id, string source) {
			this.PlugInName = "autocomplete";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);

			// Source is mandatory
			if (string.IsNullOrEmpty(source))
				throw new ArgumentException("Source is mandatory for the AutoComplete plug-in", "source");
			this.Options.Source = source;
		}


		/// <summary>
		/// Builds up the HTML for the AutoComplete control and options (and returns the generated HTML).
		/// </summary>
		/// <returns>Generated HTML for the control.</returns>
		protected internal string GetTagHtml() {
			// ID property is _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("AutoComplete ID property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			if (renderCss)
			  this.WithCss("ui-autocomplete-input");
			// turn off autocomplete, so it doesn't compete with dropdown menu
			this.WithAttribute("autocomplete", "off");

			sb.AppendTabsIf();
			sb.AppendFormat("<input id=\"{0}\"", this.ID);
			this.RenderAttributes(sb);
			sb.Append(" />");

			return sb.ToString();
		}
		

		/// <summary>
		/// Builds up the HTML for the AutoComplete control and adds to the response stream.
		/// JavaScript initialisation for the control is also added to the response stream if the
		/// AutoScript rendering option is true.
		/// </summary>
		public void Render() {
			string tagHTML = this.GetTagHtml();
			Writer.Write(tagHTML);

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}

		} // Render


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
			sb.AppendTabsFormatIf("$(\"#{0}\").autocomplete(", this.ID);
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
