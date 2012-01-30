using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Demo.Controllers
{
	public class DemoController : Controller
	{

		public ActionResult Wizard() {
			return View(new Models.WizardModel());
		}

	}
}
