using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VotacionUCAWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute("Visualizar", "{controller=Votaciones}/{id?}/{action=Candidatos}");

            routes.MapRoute(
                "Candidatos",
                "Votaciones/{id}/Candidatos",
                new { controller = "Votaciones", action = "Candidatos" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Inicio", action = "Acceso", id = UrlParameter.Optional }
            );
        }
    }
}
