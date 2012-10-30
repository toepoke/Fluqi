using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Spinner()
		{
			Models.SpinnerModel options = new Models.SpinnerModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult Spinner(Models.SpinnerModel options) {
			return View(options);
		}

	}
}
