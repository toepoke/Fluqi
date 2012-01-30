using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult PushButton()
		{
			Models.PushButtonModel options = new Models.PushButtonModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult PushButton(Models.PushButtonModel options) {
			return View(options);
		}

	}
}
