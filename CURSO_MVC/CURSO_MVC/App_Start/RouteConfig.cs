using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CURSO_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            #region METODO QUE INDICA COMO ENRUTAR LOS CONTROLADORES.

            /* ESTA SERIA LA FORMA DE COMO VAMOS A ENRUTAR TODOS LOS CONTROLADORES = CONTROLADOR - ACCION - ID */
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ); 
            #endregion
        }
    }
}
