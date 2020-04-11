using System.Web.Mvc;
using System.Web.Routing;

namespace Demo {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			AreaRegistration.RegisterAllAreas();
			RegisterRoutes(RouteTable.Routes);
		}

		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
					name: "Default",
					url: "{controller}/{action}/{id}",
					defaults: new { controller = "Home", action = "Home", id = UrlParameter.Optional }
			);
		}

	}
}
