using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Linq.Expressions;

namespace Fluqi.Web.Demo.Helpers {
	
	public static class Url {

		public static string Home(this UrlHelper url) {
			return url.Home(false);
		}

		public static string Home(this UrlHelper url, bool incProtocol) {
			string homeUrl = url.Action("Home", "Home");

			if (incProtocol)
				// this isn't very nice, but there seems to be a difference in my local MVC and the one on appHarbor
				homeUrl = "http:/" + homeUrl;

			return homeUrl;
		}

	}

}