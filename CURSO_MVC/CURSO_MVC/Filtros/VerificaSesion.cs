using CURSO_MVC.Controllers;
using CURSO_MVC.Models;
using System.Web;
using System.Web.Mvc;

namespace CURSO_MVC.Filtros
{   /* AQUI CON : ActionFilterAttribute  ESTAMOS APLICANDO UNA HERENCIA DE TODO LO QUE TIENE ESE METODO */
    public class VerificaSesion : ActionFilterAttribute
    {   
        /* CON override void OnActionExecuting OBLIGO HA HACER PRIMERO LO DE ANTES QUE ENTRE EL CONTROLADOR */

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            #region FILTRO QUE VALIDA LA VERIFICACION DE INICIO DE SESION(PARA VER SI EL USUARIO EXISTE).

            /* AHORITA VAMOS A SOBRECARGAR UN METODO Y A EVALUAR LO QUE ES LA CONEXION */
            var oUser = (usuarios)HttpContext.Current.Session["User"]; /* Veridicando si el usuario existe */

            /* CON OVERRIDE HEREDO TODO LO DEL METODO ACTIONFILTERATRIBUTE Y OBLIGO AL SISTEMA A REALIZAR UNA ACCION
               ANTES DE HACER CUALQUIER OTRA COSA Y QUE EL CONTROLADOR ENTRE */

            if (oUser == null) // VERIFICA SI EL USUARIO ES NULO 
            {
                /* ABAJO VERIFICO SI EL CONTROLADOR ES DIFERENTE AL CONTROLADOR ACCESO (QUE SERIA NUESTRO LOGIN) SII NO LO ES LO MANDA AL LOGIN*/
                if (filterContext.Controller is AccesoController == false) 
                {
                    filterContext.HttpContext.Response.Redirect("~/Acceso/Index"); // AQUI MANDO CUALQUIER PAGINA A QUE SE LOGUEE ANTES DE CUALQUIER COSA.
                }
            }
            else
            {   /* VERIFICA SI EL FILTERCONTEXT ES IGUAL AL CONTROLADOR DE ACCESO */
                if (filterContext.Controller is AccesoController == true)
                {
                    /* COMO SON IGUALES LE DA ACCESO A LA SIGUIENTE VISTA */
                    filterContext.HttpContext.Response.Redirect("~/Home/Index"); // DIRECCION DE LA VISTA DEL HOME XQ EL CONTROLADOR ES IGUAL AL ACCESOCONTROLER.
                }
            }
            /* SINO LE DA EL ACCESO AL SISTEMA COMO TAL */
            base.OnActionExecuting(filterContext); 
            #endregion
        }
    }
}