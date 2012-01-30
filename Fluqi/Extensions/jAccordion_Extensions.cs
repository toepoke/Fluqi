using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jAccordion;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating an Accordion widget through the library.
	/// </summary>
	public static partial class jAccordion_Extensions {
		
		/// <summary>
		/// Creates an accordion control from the given HTML helper object (which can then 
		/// be configured and rendered).
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="headingTag">Heading tag to use for the accordion panels (defaults to H3)</param>
		/// <returns>Created accoridon control</returns>
		public static Accordion CreateAccordion(this HtmlHelper html, string id, string headingTag) {
			TextWriter writer = html.ViewContext.Writer;
			Accordion newAccordion = new Accordion(writer, id, headingTag);

			return newAccordion;
		}


		/// <summary>
		/// Creates an accordion control from the given HTML helper object (which can then 
		/// be configured and rendered).
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="headingTag">Heading tag to use for the accordion panels (defaults to H3)</param>
		/// <returns>Created accoridon control</returns>
		public static Accordion CreateAccordion(this System.Web.UI.Page page, string id, string headingTag) {
			TextWriter writer = page.Response.Output;
			Accordion newAccordion = new Accordion(writer, id, headingTag);

			return newAccordion;
		}


		/// <summary>
		/// Creates an accordion control from the given HTML helper object (which can then 
		/// be configured and rendered).  H3 is used as the heading tag.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created accoridon control</returns>
		public static Accordion CreateAccordion(this HtmlHelper html, string id) {
			return html.CreateAccordion(id, ""/*no heading tag override - H3 is used*/);
		}


		/// <summary>
		/// Creates an accordion control from the given HTML helper object (which can then 
		/// be configured and rendered).  H3 is used as the heading tag.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <returns>Created accoridon control</returns>
		public static Accordion CreateAccordion(this System.Web.UI.Page page, string id) {
			return page.CreateAccordion(id, ""/*no heading tag override - H3 is used*/);
		}

	}


}