using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CURSO_MVC.Controllers
{
    public class CerrarController : Controller
    {
        public ActionResult LogoOff()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Acceso");
        }
    }
}