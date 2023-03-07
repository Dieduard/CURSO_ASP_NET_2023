using System;
using System.Linq;
using System.Web.Mvc;
/* AQUI VAN LAS REFERENCIAS QUE HACEN QUE SE OBTENGAN LOS DATOS AGREGADOS A LA BASE DE DATOS */
#region CONEXION ENTITY FRAMEWORK
/* INSTANCEA QUE ME PERMITE TENER CONEXION CON ENTITY FRASMEWORK */
using CURSO_MVC.Models;
#endregion

namespace CURSO_MVC.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Index()
        {
            return View();
        }
        /* CON ESTE METODO VERIFICO LA CONEXION CON LA BASE DE DATOS */

        #region METODO DE VERIFICACION DE EXISTENCIA DE USUARIO AL INICIAR SESION
        public ActionResult Enter(string user, string password)
        {
            try
            {
                ///// CONSULTA QUE SE CONECTA CON EL ENTITY FRAMEWORK ESTA ES LA FORMAR DE USAR LINQ Y VIENE SUSTITUYENDO SQL.
                using (BD_USUARIOSEntities db = new BD_USUARIOSEntities())
                {
                    var lst = from d in db.usuarios
                              where d.Email == user && d.Passwordd == password && d.CodEstado == 1
                              select d; // esto se pone para que seleccione todos los atributos 

                    /* ESTA ES LA FORMA DE CREAR UNA SESSION EN C#  Y VERIFICAR SI EXISTE EL USUARIO */
                    if (lst.Count() > 0)
                    {
                        usuarios oUser = lst.First();
                        Session["User"] = oUser;                // COMO INICIAR SESSION  
                        //Session["User"] = lst.First();
                        return Content("1");
                    }
                    else
                    {
                        return Content("Usuario o Contraseña Errónea");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error" + ex.Message);
                //throw;
            }
        } 
        #endregion
    }
}