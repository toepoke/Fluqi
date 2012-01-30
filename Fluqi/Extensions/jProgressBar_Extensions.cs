using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jProgressBar;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a ProgressBar widget through the library.
	/// </summary>
	public static partial class jAccordion_Extensions {
		
		/// <summary>
		/// Creates a ProgressBar control that can be configured and later rendered onto the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created ProgressBar control</returns>
		public static ProgressBar CreateProgressBar(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			ProgressBar pb = new ProgressBar(writer, id);

			return pb;
		}

		/// <summary>
		/// Creates a ProgressBar control that can be configured and later rendered onto the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created ProgressBar control</returns>
		public static ProgressBar CreateProgressBar(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			ProgressBar pb = new ProgressBar(writer, id);

			return pb;
		}

	}


}