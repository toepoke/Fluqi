namespace Fluqi.Utilities.jAnimation {
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

	public partial class Animation {
		/// <summary>
		/// Response object to write the control to.
		/// </summary>
		public TextWriter Writer { get; private set; }

		/// <summary>
		/// Specifies the options to be adopted for this object (see <see cref="Options"/> class
		/// for full details)
		/// </summary>
		public Options Options {get; set;}

		/// <summary>
		/// Specifies the settings to be adopted when rendering the control (e.g. whether to compress the JavaScript, 
		/// include jQuery UI class names, etc.
		/// </summary>
		public Rendering Rendering { get; set; }


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="writer">Response stream to write the control to.</param>
		/// <param name="id">ID of the button, this must be unique for the page</param>
		public Animation(TextWriter writer, string key) {
			this.Writer = writer;
			this.Options = new Options(this, key);
			this.Rendering = new Rendering(this);
		}


		/// <summary>
		/// There is not underlying control for a Animation object to render onto.  The "Render"
		/// method merely calls the initialisation routine and adds it into the outgoing Response
		/// object
		/// </summary>
		public void Render() {
			Writer.Write( this.GetStartUpScript(this.Rendering.AutoScript) );
		}


		/// <summary>
		/// Writes out the calling script for the jQuery Tabs plugin, adding options that have been
		/// a defined.
		/// </summary>
		/// <param name="tabDepth">
		/// How far to indent the tabs in the script code.
		/// </param>
		/// <returns>
		/// Returns rendered initialisation script
		/// </returns>
		public string GetControlScript(int tabDepth) {
			jStringBuilder sb = new jStringBuilder(this.Rendering.PrettyRender, this.Rendering.TabDepth);
			
			//sb.IncIndent();
			//sb.AppendTabsFormatIf("$.cookie(", this.ID);
			Core.ScriptOptions options = new Core.ScriptOptions();
			this.Options.DiscoverOptions(options);
			options.Render(sb);
			//sb.Append(");");
			//sb.DecIndent();
			
			return sb.ToString();
		}
	}


}
