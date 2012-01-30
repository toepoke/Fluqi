using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult ProgressBar()
		{
			Models.ProgressBarModel options = new Models.ProgressBarModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult ProgressBar(Models.ProgressBarModel options) {
			return View(options);
		}

	}
}
