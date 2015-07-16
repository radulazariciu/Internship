using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "NewRoute",
                url: "1/{name}",
                defaults: new { controller = "TheNew", action = "FirstOption", name=""}
                );

            routes.MapRoute(
                name: "abcd",
                url: "2/{name}",
                defaults: new {controller = "TheNew", action = "SecondOption", name = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "someName",
                url: "3",
                defaults: new { controller = "TheNew", action = "ThirdOption", name = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
