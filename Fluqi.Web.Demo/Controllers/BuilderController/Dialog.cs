using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Dialog()
		{
			Models.DialogModel options = new Models.DialogModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult Dialog(Models.DialogModel options) {
			return View(options);
		}

	}
}
