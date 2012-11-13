using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jToolTip;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a ToolTip widget through the library.
	/// </summary>
	public static partial class jToolTip_Extensions
	{
		
		/// <summary>
		/// Creates a ToolTip control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <returns>Created ToolTip control</returns>
		public static ToolTip CreateToolTips(this HtmlHelper html) {
			TextWriter writer = html.ViewContext.Writer;
			ToolTip newToolTip = new ToolTip(writer);

			return newToolTip;
		}

		/// <summary>
		/// Creates a ToolTip control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to target the tooltip (must be unique on the page)</param>
		/// <returns>Created ToolTip control</returns>
		public static ToolTip CreateToolTip(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			ToolTip newToolTip = new ToolTip(writer, id);

			return newToolTip;
		}

		/// <summary>
		/// Creates a ToolTip control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to target the tooltip on (must be unique on the page)</param>
		/// <returns>Created ToolTip control</returns>
		public static ToolTip CreateToolTip(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			ToolTip newToolTip = new ToolTip(writer, id);

			return newToolTip;
		}

	}
	
}