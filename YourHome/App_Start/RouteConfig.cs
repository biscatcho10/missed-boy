using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YourHome
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                          name: "Default1",
                          url: "{controller}/{action}/{id}/{CategoryId}",
                          defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, CategoryId=UrlParameter.Optional }
                      );

            routes.MapRoute(
                   name: "Default2",
                   url: "{controller}/{action}/{id}/{CategoryId}/{fe2aId}",
                   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, CategoryId = UrlParameter.Optional,fe2a=UrlParameter.Optional}
               );


            routes.MapRoute(
                   name: "Default3",
                   url: "{controller}/{action}/{id}/{CategoryId}/{fe2aId}/{s}",
                   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, CategoryId = UrlParameter.Optional, fe2a = UrlParameter.Optional,s=UrlParameter.Optional}
               );

        }
    }
}
