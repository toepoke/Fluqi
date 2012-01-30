using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Accordion()
		{
			Models.AccordionModel options = new Models.AccordionModel();

			return View(options);
		}

		[HttpPost()]
		public ActionResult Accordion(Models.AccordionModel options) {
			return View(options);
		}

	}
}
