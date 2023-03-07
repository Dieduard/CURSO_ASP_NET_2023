using System.Web;
using System.Web.Mvc;

namespace CURSO_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            /* FILTROS DE SEGURIDAD IMPLEMENTADOS EN NUESTRO SISTEMA */

            #region AQUI ESTARAN AGREGADAS TODOS LOS FILTROS QUE IMPLEMENTE EN EL SISTEMA.
            filters.Add(new HandleErrorAttribute());
            /* CON ESTA LINEA DE ABAJO HAGO VALER EL FILTRO QUE HE HECHO AL INICIO DE SESION */
            filters.Add(new Filtros.VerificaSesion()); 
            #endregion
        }
    }
}
