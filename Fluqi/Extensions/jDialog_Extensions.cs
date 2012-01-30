using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jDialog;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Dialog widget through the library.
	/// </summary>
	public static partial class jDialog_Extensions {
		
		/// <summary>
		/// Creates a Dialog control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Dialog control</returns>
		public static Dialog CreateDialog(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			Dialog newDialog = new Dialog(writer, id);

			return newDialog;
		}

		/// <summary>
		/// Creates a Dialog control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Dialog control</returns>
		public static Dialog CreateDialog(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			Dialog newDialog = new Dialog(writer, id);

			return newDialog;
		}

		/// <summary>
		/// Closes the Dialog control HTML (used when the "using" pattern isn't used).
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		public static void EndDialog(this HtmlHelper html) {
			TextWriter writer = html.ViewContext.Writer;
			writer.Write("</div>");
		}

		/// <summary>
		/// Closes the Dialog control HTML (used when the "using" pattern isn't used).
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		public static void EndDialog(this System.Web.UI.Page page) {
			TextWriter writer = page.Response.Output;
			writer.Write("</div>");
		}

	}


}