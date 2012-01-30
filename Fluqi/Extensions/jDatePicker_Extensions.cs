using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jDatePicker;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a DatePicker widget through the library.
	/// </summary>
	public static partial class jTab_Extensions {
		
		/// <summary>
		/// Creates a DatePicker control that can be later rendered onto the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created DatePicker control</returns>
		public static DatePicker CreateDatePicker(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			DatePicker newTabs = new DatePicker(writer, id);

			return newTabs;
		}

		/// <summary>
		/// Creates a DatePicker control that can be later rendered onto the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created DatePicker control</returns>
		public static DatePicker CreateDatePicker(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			DatePicker newTabs = new DatePicker(writer, id);

			return newTabs;
		}

	}

}