using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fluqi.Widget.jAutoComplete;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Fluqi.Extension {

	/// <summary>
	/// Set of extensions to the Html and Page objects for creating an AutoComplete widget through the library.
	/// </summary>
	public static partial class jAccordion_Extensions
	{
		
		/// <summary>
		/// Creates an AutoComplete control that can then be configured and rendered on the page.
		/// </summary>
		/// <param name="html">Html helper (used to get the HttpResponse object to render onto)</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="source">Source to use for the AutoComplete control 
		/// (can be a JavaScript array, JavaScript callback function, URL, etc - see https://jqueryui.com/demos/autocomplete/#option-source </param>
		/// <returns>Created AutoComplete control</returns>
		public static AutoComplete CreateAutoComplete(this HtmlHelper html, string id, string source) 
		{
			TextWriter writer = html.ViewContext.Writer;
			AutoComplete ac = new AutoComplete(writer, id, source);

			return ac;
		}

		/// <summary>
		/// Creates an AutoComplete control that can then be configured and rendered on the page.
		/// </summary>
		/// <param name="page">WebForms page to render the control onto</param>
		/// <param name="id">ID to give to the accordion (must be unique on the page)</param>
		/// <param name="source">Source to use for the AutoComplete control 
		/// (can be a JavaScript array, JavaScript callback function, URL, etc - see https://jqueryui.com/demos/autocomplete/#option-source </param>
		/// <returns>Created AutoComplete control</returns>
		public static AutoComplete CreateAutoComplete(this System.Web.UI.Page page, string id, string source) 
		{
			TextWriter writer = page.Response.Output;
			AutoComplete ac = new AutoComplete(writer, id, source);

			return ac;
		}

	}


}