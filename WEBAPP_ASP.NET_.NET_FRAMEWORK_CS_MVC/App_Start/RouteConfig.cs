using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WEBAPP_ASP.NET_.NET_FRAMEWORK_CS_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Auth", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Client/{codeClient}",
                url: "Client/{controller}/{action}/{id}",
                defaults: new { controller = "Client", action = "GetClient", id = "codeClient" }
            );

        }
    }
}
