using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult ToolTip()
		{
			Models.ToolTipModel options = new Models.ToolTipModel();
			
			return View(options);
		}

		[HttpPost()]
		public ActionResult ToolTip(Models.ToolTipModel options) {
			return View(options);
		}

	}
}
