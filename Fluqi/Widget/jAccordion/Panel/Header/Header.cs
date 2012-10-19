using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Extension.Helpers;

namespace Fluqi.Widget.jAccordion {
	
	public partial class Header: Core.ControlBase {

		/// <summary>
		/// Holds a reference to the Panel the header is on
		/// </summary>
		protected internal Panel OnPanel { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="panel">Panel the header is for</param>
		public Header(Panel panel) {
			this.OnPanel = panel;
		}


		/// <summary>
		/// Returns the Panel the header is on to maintain the fluent
		/// interface.
		/// </summary>
		public Panel Finish() {
			return this.OnPanel;
		}

		/// <summary>
		/// Renders the panel header and returns the HTML
		/// </summary>
		/// <returns></returns>
		internal string GetTagHtml() {
			Accordion ac = this.OnPanel.OnAccordion;
			bool prettyRender = ac.Rendering.PrettyRender;
			bool renderCss = ac.Rendering.RenderCSS;
			int tabDepth = ac.Rendering.TabDepth;
			jStringBuilder sb = new jStringBuilder(prettyRender, tabDepth + 1); 

			// H3 tag (or whatever if it's been overridden in the options)
			sb.AppendLineIf();
			sb.AppendTabsFormatIf("<{0}", ac.Options.HeadingTag);
			
			if (renderCss) {
				base.WithCss("ui-accordion-header ui-helper-reset ui-state-default");

				if (this.OnPanel.IsActive) 
					base.WithCss("ui-state-active ui-corner-top");
				else 
					base.WithCss("ui-corner-all");
			}

			// add in any attributes the user has added
			base.RenderAttributes(sb);

			// and close off the starting H3 tag
			sb.Append(">");

			sb.Append(this.OnPanel.Title);

			// Closing heading (H3)
			sb.AppendFormatLineIf("</{0}>", ac.Options.HeadingTag);

			return sb.ToString();
		}

	}

}
