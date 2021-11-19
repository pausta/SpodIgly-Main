using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpodIgly_Main
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(

                name: "ProductDetails",
                url: "album-{id}.html",
                defaults: new { controller = "Store", action = "Details" }
                );


            routes.MapRoute(

                name: "StaticPages",
                url: "strony/{viewname}.html",
                defaults: new { controller = "Home", action = "StaticContent" }   // Action musi być utworzony w Home Controller (NIE w Store controller)
                );

            routes.MapRoute(

                name: "ProductList",
                url: "gatunki/{genrename}",
                defaults: new { controller = "Store", action = "List" },
                constraints: new { genrename = @"[\w& ]+"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
        }
    }

}

