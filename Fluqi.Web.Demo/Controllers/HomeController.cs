using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluqi.Controllers
{

	[HandleError]
	public class HomeController : Controller
	{	
		// cache the output for a day
		[OutputCache(Duration=86000, VaryByParam="none")]
		public ActionResult Home() 
		{
			return View();
		}

		[OutputCache(Duration=86000, VaryByParam="none")]
		public ActionResult History() 
		{
			return View();
		}

	}
}
