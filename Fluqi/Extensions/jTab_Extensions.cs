using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jTab;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating a Tab widget through the library.
	/// </summary>
	public static partial class jTab_Extensions {
		
		/// <summary>
		/// Creates a Tabs control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Tabs control</returns>
		public static Tabs CreateTabs(this HtmlHelper html, string id) {
			TextWriter writer = html.ViewContext.Writer;
			Tabs newTabs = new Tabs(writer, id);

			return newTabs;
		}

		/// <summary>
		/// Creates a Tabs control that can be configured and later rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created Tabs control</returns>
		public static Tabs CreateTabs(this System.Web.UI.Page page, string id) {
			TextWriter writer = page.Response.Output;
			Tabs newTabs = new Tabs(writer, id);

			return newTabs;
		}


		/// <summary>
		/// Closes the Dialog control HTML (used when the "using" pattern isn't used).
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		public static void EndTabs(this HtmlHelper html) {
			TextWriter writer = html.ViewContext.Writer;
			writer.Write("</div>");
		}

		/// <summary>
		/// Closes the Dialog control HTML (used when the "using" pattern isn't used).
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		public static void EndTabs(this System.Web.UI.Page page) {
			TextWriter writer = page.Response.Output;
			writer.Write("</div>");
		}

	}


}