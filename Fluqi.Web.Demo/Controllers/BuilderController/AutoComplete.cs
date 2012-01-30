using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult AutoComplete()
		{
			Models.AutoCompleteModel options = new Models.AutoCompleteModel();

			return View(options);
		}

		[HttpPost()]
		public ActionResult AutoComplete(Models.AutoCompleteModel options) {
			return View(options);
		}

		public JsonResult AutoCompleteResults(string term) {
			// just return out list of icon names
			List<string> iconNames = Fluqi.Core.Icons.ToList();
			
			// strip off the "ui-icon-" prefix as they all start with that
			var hits = (
				from i 
				in iconNames 
				select new { 
					// jQuery UI expects the results to come back with a "label" property
					label = i.Substring("ui-icon-".Length)
				}
			).ToList();

			// limit the results if a term filter is present
			if (!string.IsNullOrEmpty(term)) {
				hits = (
					from h
					in hits 
					where h.label.Contains(term)
					select h
				).ToList();
			}

			return this.Json(hits, JsonRequestBehavior.AllowGet);
		}

	}
}
