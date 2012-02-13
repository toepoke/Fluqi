using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion {
	
	/// <summary>
	/// Hyperlink that appears in the header of the accordion panel.
	/// </summary>
	public partial class Hyperlink: Core.Hyperlink {

		/// <summary>
		/// Header object the hyperlink is part of.
		/// </summary>
		protected internal Header _Header = null;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="header">Header this hyperlink belongs to</param>
		public Hyperlink(Header header) {
			_Header = header;
			// just an anchor by default as usually this is what you want
			this.URL = "#";
		}

		/// <summary>
		/// Returns the fluent interface back to the panel header.
		/// </summary>
		public Header Finish() {
			return _Header;
		}

		/// <summary>
		/// Specifies the title that should appear in the panel
		/// </summary>
		/// <param name="title">Title to appear in the panel</param>
		/// <returns>Header of the panel to main the fluent interface</returns>
		public Hyperlink SetTitle(string title) {
			this.Title = title;
			return this;
		}

		/// <summary>
		/// Specifies where the panel header should link to.  
		/// Normally this is just to the anchor in the accordion control.
		/// Be _VERY_ careful changing this to anything other than "#"
		/// as it probably won't do what you think or want.
		/// </summary>
		/// <param name="url">URL to link to when the panel is clicked</param>
		/// <returns>Header of the panel to main the fluent interface</returns>
		public Hyperlink SetURL(string url) {
			this.URL = url;
			return this;
		}

		/// <summary>
		/// Renders the HTML for the hyperlink.
		/// </summary>
		/// <returns>String of HTML</returns>
		public string GetTagHtml() {
			Accordion ac = this._Header.OnPanel.OnAccordion;
			bool prettyRender = ac.Rendering.PrettyRender;
			bool renderCss = ac.Rendering.RenderCSS;
			int tabDepth = ac.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth); 

			sb.AppendTabsFormatIf("<a href=\"{0}\">", this.URL);
			base.RenderAttributes(sb);
			sb.Append(this.Title);
			sb.Append("</a>");

			return sb.ToString();
		}

	}

}
