using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Slider()
		{
			Models.SliderModel options = new Models.SliderModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult Slider(Models.SliderModel options) {
			return View(options);
		}

	}
}
