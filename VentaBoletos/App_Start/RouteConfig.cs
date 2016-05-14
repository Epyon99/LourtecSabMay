using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VentaBoletos
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Filtro viaje 1p",
                url: "Viaje/{tipoBusqueda}/{valor1}",
                defaults: new { controller = "Viaje", action = "Buscar"}
            );

            routes.MapRoute(
                name: "Filtro viaje 2p",
                url: "Viaje/{tipoBusqueda}/{valor1}/{valor2}",
                defaults: new { controller = "Viaje", action = "Buscar"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
