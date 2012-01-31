using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Linq.Expressions;

namespace Fluqi.Web.Demo.Helpers {
	
	public static class Url {

		public static string SiteRoot(HttpContextBase context) {            
			return SiteRoot(context, true);        
		}        
		
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
		
		public static string SiteRoot(this UrlHelper url) {            
			return SiteRoot(url.RequestContext.HttpContext);        
		}        
		
	}
	
}