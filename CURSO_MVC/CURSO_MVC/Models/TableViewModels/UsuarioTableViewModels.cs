using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURSO_MVC.Models.TableViewModels
{
    public class UsuarioTableViewModels
    {
        /* ATRIBUTOS DE LA CLASE USUARIOS SE HACE DE LA SIGUIENTE FORMA */

        #region TODOS LOS ATRIBUTOS DE LA CLASE USUARIO 
        public int Id { get; set; }
        public string Email { get; set; }
        public int? Edad { get; set; }

        #endregion
    }
}