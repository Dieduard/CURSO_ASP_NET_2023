using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;  
using CURSO_MVC.Models;                 /*HAGO REFERENCIA AL MODELO PARA PODER TENER ACCESO A LOS DATOS  */
using CURSO_MVC.Models.TableViewModels; /* HAGO REFERENCIA A LA TABLA DEL MODELO Y DE UN SOLO TENER ACCESO A LOS DATOS */
using CURSO_MVC.Models.ViewModel;

namespace CURSO_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        #region METODO QUE ME SIRVE PARA IR A TRAER LOS DATOS DE MI BASE DE DATOS Y ASI PODER MOSTRARLOS EN LA VISTA 
        public ActionResult Index()
        {
            /* ESTA SERIA LA FORMA DE IR A TRAER LOS DATOS A LA BASE DE DATOS Y PODERLOS MOSTRAR */
            List<UsuarioTableViewModels> lst = null;
            using (BD_USUARIOSEntities db = new BD_USUARIOSEntities())
            {
                lst = (from d in db.usuarios
                       where d.CodEstado == 1
                       //orderby d.Id  /*DE ESTA FORMA LOS PODEMOS ORDENAR */
                       select new UsuarioTableViewModels
                       {
                           Email = d.Email,
                           Id = d.Id,
                           Edad = d.Edad
                       }).ToList();
            }
            return View(lst);
        }
        #endregion

        #region TODOS LOS METODOS QUE HACEN REFERENCIA AL FORMULARIO AGREGAR USUARIO (( ADD == AGREGAR ))

        [HttpGet] /* GET == FORMA DE CONSULTAR A LA BASE DE DATOS Y OBTENER LA INFORMACION */
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost] /* FORMA DE COMO ENVIAR LOS DATOS A LA API QUE SE ALMACENARA EN NUESTRA BASE DE DATOS */
        public ActionResult Add(UsuarioViewModel model)
        {
            /*FORMA DE VALIDAR EL DATANOTATION */
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            /*AHORA SE PROCEDE GUARDARLO A LA BASE DE DATOS */
            using (var db = new BD_USUARIOSEntities())
            {
                usuarios oUsuario = new usuarios();
                oUsuario.CodEstado = 1;
                oUsuario.Email = model.Email;
                oUsuario.Edad = model.Edad;
                oUsuario.Passwordd = model.Password;

                db.usuarios.Add(oUsuario);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/Usuario/"));
        }
        #endregion

        #region TODOS LOS METODOS QUE HACEN REFERENCIA AL FORMULARIO EDITAR USUARIO (( EDIT ))
        
        public ActionResult Edit(int Id)
        {
            /* AHORITA VAMOS A LLENAR LOS DATOS QUE VAMOS A EDITAR */
            EditUsuarioViewModel model = new EditUsuarioViewModel();
            using (var db = new BD_USUARIOSEntities())
            {
                var oUsuario = db.usuarios.Find(Id);
                model.Edad = (int)oUsuario.Edad;
                model.Email = oUsuario.Email;
            }
            return View(model);
        }

        //[HttpPost] /* SIRVE PARA OBTENER LOS DATOS DE MI BASE DE DATOS */
        //public ActionResult Edit(EditUsuarioViewModel model)
        //{
        //    /*FORMA DE VALIDAR EL MODELO SINO ME LO RETORNA */
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    /* AHORITA VAMOS A LLENAR LOS DATOS QUE VAMOS A EDITAR */
        //    EditUsuarioViewModel model = new EditUsuarioViewModel();
        //    using (var db = new BD_UsuarioEntities2())
        //    {
        //        var oUsuario = db.usuarios.Find(Id);
        //        model.Edad = (int)oUsuario.Edad;
        //        model.Email = oUsuario.Email;
        //    }
        //    return Redirect(Url.Content("~/Usuario/"));
        //}

     
        #endregion


    }
}

