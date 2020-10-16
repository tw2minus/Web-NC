﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace XePKL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Product Detail",
              url: "chi-tiet/{metatitle}-{id}",
              defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
              namespaces: new[] { "XePKL.Controllers" }
          );

            routes.MapRoute(
               name: "About",
               url: "gioi-thieu",
               defaults: new { controller = "About", action = "Detail", id = UrlParameter.Optional },
               namespaces: new[] { "XePKL.Controllers" }
       );
            routes.MapRoute(
               name: "Product Category",
               url: "san-pham/{metatitle}-{cateId}",
               defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
               namespaces: new[] { "XePKL.Controllers" }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "XePKL.Controllers" }
            ); 
        }
    }
}
