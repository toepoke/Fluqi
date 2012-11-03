using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jMenu;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Menu widget through the library.
	/// </summary>
	public static partial class jMenu_Extensions
	{
		
		/// <summary>
		/// Creates a Menu control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Menu control</returns>
		public static Menu CreateMenu(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			Menu newMenu = new Menu(writer, id);

			return newMenu;
		}

		/// <summary>
		/// Creates a Menu control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Menu control</returns>
		public static Menu CreateMenu(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			Menu newMenu = new Menu(writer, id);

			return newMenu;
		}

	}


}