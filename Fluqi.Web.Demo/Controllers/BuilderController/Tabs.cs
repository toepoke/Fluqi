using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Web.Builder.Controllers
{
	public partial class BuilderController : Controller
	{

		public ActionResult Tabs()
		{
			Models.TabModel options = new Models.TabModel();
			return View(options);
		}

		[HttpPost()]
		public ActionResult Tabs(Models.TabModel options) {
			return View(options);
		}

		[HttpGet()]
		public ActionResult GetDynamicTab() {
			var httpCtx = this.ControllerContext.RequestContext.HttpContext;

			// yeah, this is nasty, but it's a demo :D
			if (httpCtx.Application["TabIndex"] == null) 
				httpCtx.Application["TabIndex"] = -1;
			httpCtx.Application["TabIndex"] = (int)httpCtx.Application["TabIndex"] + 1;
						
			// Deliberate sleep to make it look like it takes a while to load
			System.Threading.Thread.Sleep(2000);
			return PartialView("AddTab", (int)httpCtx.Application["TabIndex"]);
		}

	}
}
