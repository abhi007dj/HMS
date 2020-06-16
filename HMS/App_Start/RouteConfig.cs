using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HMS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              //  Areas:"Dashboard",
                name: "Default",
                url: "{controller}/{action}/{id}",
                              //  defaults: new { controller = "AccomodationTypes", action = "Listing", id = UrlParameter.Optional }
                              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );
        }
    }
}
