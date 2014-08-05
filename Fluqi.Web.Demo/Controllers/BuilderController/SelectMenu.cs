using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult SelectMenu()
		{
			var options = new Models.SelectMenuModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult SelectMenu(Models.SelectMenuModel options) {
			return View(options);
		}

	}
}
