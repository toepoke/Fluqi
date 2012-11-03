using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Menu()
		{
			Models.MenuModel options = new Models.MenuModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult Menu(Models.MenuModel options) {
			return View(options);
		}

	}
}
