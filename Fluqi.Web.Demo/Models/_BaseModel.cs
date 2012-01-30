using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Fluqi.Extension.Helpers;
using System.IO;

namespace Fluqi.Models
{

	public class BaseModel {
		public BaseModel() {
			this.showEvents = true;
			this.renderCSS = false;
			this.prettyRender = true;

		}

		/// <summary>
		/// Wires up the events for the control being show so we can see how they are called.
		/// </summary>
		[DisplayName("Show & Render Events")]
		public bool showEvents { get; set; }

		/// <summary>
		/// Flags that the CSS for the control should be rendered (useful if you 
		/// still want the look of the jQuery UI controls when the user does not have
		/// JavaScript available.
		/// </summary>
		[DisplayName("Show CSS")]
		public bool renderCSS { get; set; }

		/// <summary>
		/// jQuery UI JavaScript is rendered in an indented format making it easier to 
		/// read.
		/// </summary>
		[DisplayName("Show readable layout")]
		public bool prettyRender { get; set; }

		public TextWriter Writer { get; set; }

		protected string RenderCSharpCode() {
			jStringBuilder sb = new jStringBuilder(true/*includeWhitespace*/, 1);
			
			if (this.renderCSS || !this.prettyRender) {
				// only add if we're using the non-default settings
				sb.AppendTabsLineIf(".Rendering");
				sb.IncIndent();
				if (!this.prettyRender)
					sb.AppendTabsLineIf(".Compress()");
				if (this.renderCSS)
					sb.AppendTabsLineIf(".ShowCSS()");
				sb.DecIndent();
				sb.AppendTabsLineIf(".Finish()");
			}

			return sb.ToString();
		}
	}

}
