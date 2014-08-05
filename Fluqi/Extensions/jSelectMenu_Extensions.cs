using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Fluqi.Widget.jSelectMenu;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Menu widget through the library.
	/// </summary>
	public static partial class jSelectMenu_Extensions
	{
		
		/// <summary>
		/// Creates a Menu control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Menu control</returns>
		public static SelectMenu CreateSelectMenu(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			SelectMenu selectMenu = new SelectMenu(writer, id);

			return selectMenu;
		}

		/// <summary>
		/// Creates a Menu control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Menu control</returns>
		public static SelectMenu CreateMenu(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			SelectMenu selectMenu = new SelectMenu(writer, id);

			return selectMenu;
		}

	}


}