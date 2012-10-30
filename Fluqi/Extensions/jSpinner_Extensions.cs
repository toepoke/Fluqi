using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jSpinner;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Spinner widget through the library.
	/// </summary>
	public static partial class jSpinner_Extensions
	{
		
		/// <summary>
		/// Creates a Spinner control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Spinner control</returns>
		public static Spinner CreateSpinner(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			Spinner newSpinner = new Spinner(writer, id);

			return newSpinner;
		}

		/// <summary>
		/// Creates a Spinner control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Spinner control</returns>
		public static Spinner CreateSpinner(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			Spinner newSpinner = new Spinner(writer, id);

			return newSpinner;
		}

	}


}