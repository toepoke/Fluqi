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

namespace Fluqi.Widget.jMenu
{
	public partial class Menu: Core.ControlBase, IControlRenderer, IControl
	{
		/// <summary>
		/// Name of the control being rendered.  This string is used when calling into the jQuery 
		/// control itself, and so must match the control name in the jQuery UI JavaScript files
		/// </summary>
		/// <remarks>
		/// For the Menu control, this is "menu".
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
		/// Specifies any child menu items
		/// </summary>
		protected internal jMenuItem.MenuItem Root { get; set; }

		public jMenuItem.MenuItems Items() {
			return this.Root.Children;
		}


		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		public Menu(TextWriter writer)
			: this(writer, "") 
		{ 
		}
		
		/// <summary>
		/// Detailed constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to</param>
		/// <param name="id">ID of the control (which must be unique on the page)</param>
		public Menu(TextWriter writer, string id) {
			this.PlugInName = "menu";
			this.Writer = writer;
			this.ID = id;
			this.Root = new jMenuItem.MenuItem(this, id);
			this.Options = new Options(this);
			this.Events = new Events(this);
			this.Methods = new Methods(this);
			this.Rendering = new Rendering(this);
		}


		/// <summary>
		/// Builds and returns the HTML for the Menu control (basically the DIV).
		/// JavaScript initialisation for the control is also added to the response stream if the
		/// AutoScript rendering option is true.
		/// </summary>
		/// <returns>HTML for the Menu control.</returns>
		protected internal string GetTagHtml() {
			// ID property is _mandatory_
			if (string.IsNullOrEmpty(this.ID))
				throw new ArgumentException("Menu ID property _must_ be supplied.");

			bool prettyRender = this.Rendering.PrettyRender;
			bool renderCss = this.Rendering.RenderCSS;
			int tabDepth = this.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth);

			this.WithID(this.ID);
			if (renderCss)
				// it's the top level, so output CSS (if required)
				this.WithCss("ui-menu ui-widget ui-widget-content ui-corner-all");

			this.Root.BuildTagHtml(sb);

			if (this.Rendering.AutoScript) {
				this.RenderStartUpScript();
			}

			return sb.ToString();

		} // GetTagHtml


		/// <summary>
		/// Writes the HTML for the Menu control to the response stream.
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
			
			sb.IncIndent();
			sb.AppendTabsFormatIf("$(\"#{0}\").menu(", this.ID);
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
