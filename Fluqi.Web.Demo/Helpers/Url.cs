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
#if DEBUG
			return url.SiteRoot(true);
#else 
			// Yup, this is really bad but appHarbor will insist on appending port number :(
			// Besides, it's a demo :)
			return "http://fluqi.apphb.com/";
#endif
		}

		public static string SiteRoot(HttpContextBase context) {
			return SiteRoot(context, true);
		}
		
		/// <summary>
		/// Returns the full URL (including http://, port number, etc).
		/// </summary>
		/// <param name="context">Context being used</param>
		/// <param name="usePort">Flags port should be included</param>
		/// <returns>
		/// Blatantly nicked from RobC - http://wekeroad.com/2010/01/20/my-favorite-helpers-for-aspnet-mvc/
		/// </returns>
		public static string SiteRoot(HttpContextBase context, bool usePort) {
			var Port = context.Request.ServerVariables["SERVER_PORT"];
			if (usePort) {
				if (Port == null || Port == "80" || Port == "443")
					Port = "";
				else
					Port = ":" + Port;
			}
			var Protocol = context.Request.ServerVariables["SERVER_PORT_SECURE"];
			if (Protocol == null || Protocol == "0")
				Protocol = "http://";
			else
				Protocol = "https://";
			var appPath = context.Request.ApplicationPath;
			if (appPath == "/")
				appPath = "";

			var sOut = Protocol + context.Request.ServerVariables["SERVER_NAME"] + Port + appPath;

			return sOut;
		}
		
		/// <summary>
		/// Returns the full URL (including http://, port number, etc).
		/// </summary>
		/// <param name="url">UrlHelper to use</param>
		/// <returns>
		/// Blatantly nicked from RobC - http://wekeroad.com/2010/01/20/my-favorite-helpers-for-aspnet-mvc/
		/// </returns>
		public static string SiteRoot(this UrlHelper url) {
			return SiteRoot(url.RequestContext.HttpContext);
		}

		/// <summary>
		/// Returns the full URL (including http://, port number, etc).
		/// </summary>
		/// <param name="url">UrlHelper to use</param>
		/// <param name="usePort">Flags port should be included</param>
		/// <returns>
		/// Blatantly nicked from RobC - http://wekeroad.com/2010/01/20/my-favorite-helpers-for-aspnet-mvc/
		/// </returns>
		public static string SiteRoot(this UrlHelper url, bool usePort) {
			return SiteRoot(url.RequestContext.HttpContext, usePort);
		}
		
	}
	
}