using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Fluqi.Extension.Helpers;
using Fluqi.Extension;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;
using Fluqi.Core.Interfaces;
using System.IO;

namespace Fluqi.Widget.jToolTip
{
	public partial class ToolTip: Core.ControlBase, IControlRenderer, IControl
	{
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the ToolTip control, this is "tooltip".
		/// </remarks>
		public string PlugInName { get; protected internal set; }

		/// <summary>
		/// ID of the control to apply the tooltip to (or "document" to apply to the full page).
		/// By default this is to the "document" level (and cascading downwards).
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
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		public ToolTip(TextWriter writer)
			: this(writer, Options.DEFAULT_TARGET) 
		{ 
		}
		
		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		/// <param name="id">
		/// ID of the control (which must be unique on the page)
		/// Leave this empty to apply the tooltip settings to everything on the page (e.g. if you're targetting the
		/// [title] attribute for everything on the page)
		/// </param>
		public ToolTip(TextWriter writer, string id) {
			this.PlugInName = "tooltip";
			this.Writer = writer;
			this.ID = id;
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
		}


		/// <summary>
		/// Builds and returns the HTML for the ToolTip control (basically the DIV).
		/// JavaScript initialisation for the control is also added to the response stream if the
		/// AutoScript rendering option is true.
		/// </summary>
		/// <returns>HTML for the ToolTip control.</returns>
		protected internal string GetTagHtml() {
			// Selector property is _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("ToolTip \"ID\" property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}

			return sb.ToString();

		} // GetTagHtml


		/// <summary>
		/// Writes the HTML for the ToolTip control to the response stream.
		/// </summary>
		public void Render() {
			string tagHtml = this.GetTagHtml();

			Writer.Write(tagHtml);
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
			string selector = "";
	
			if (IsGlobal())
				selector = Options.DEFAULT_TARGET;
			else 
				selector = string.Format("\"#{0}\"", this.ID);
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$({0}).tooltip(", selector);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			this.Events.DiscoverOptions(options);
			options.Render(sb);
			sb.Append(");");
			sb.DecIndent();
			
			return sb.ToString();
		}


		/// <summary>
		/// Flags that tooltip settings should be applied globally on the page
		/// </summary>
		/// <remarks>
		/// In essence this just looks for an empty ID.  If the ID is empty, we're not targetting a 
		/// specific element => we're targetting everything on the page
		/// </remarks>
		protected internal bool IsGlobal() {
			if (string.IsNullOrEmpty(this.ID))
				return true;
			// there's no doubt more ways than just "document" and "window", but this isn't a full attempt, just
			// catching noddy scenarios as the user should really be using an empty selector to signify it's against the page
			if (string.Equals(this.ID, "document", StringComparison.CurrentCultureIgnoreCase))
				return true;
			if (string.Equals(this.ID, "window", StringComparison.CurrentCultureIgnoreCase))
				return true;
			return false;
		}

	}
}
