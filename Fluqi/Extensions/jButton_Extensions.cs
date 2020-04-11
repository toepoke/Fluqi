using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jPushButton;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a PushButton widget through the library.
	/// </summary>
	public static partial class jAccordion_Extensions
	{

		/// <summary>
		/// Creates a Button control (see https://jqueryui.com/demos/button/ for details) that can be 
		/// later configured and rendered to the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="label">Text to appear on the button</param>
		/// <returns>Created Button control</returns>
		public static PushButton CreateButton(this HtmlHelper html, string id, string label) {
			TextWriter writer = html.ViewContext.Writer;
			PushButton btn = new PushButton(writer, id, label);

			return btn;
		}

		/// <summary>
		/// Creates a Button control (see https://jqueryui.com/demos/button/ for details) that can be 
		/// later configured and rendered to the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="label">Text to appear on the button</param>
		/// <returns>Created Button control</returns>
		public static PushButton CreateButton(this System.Web.UI.Page page, string id, string label) {
			TextWriter writer = page.Response.Output;
			PushButton btn = new PushButton(writer, id, label);

			return btn;
		}

	}


}