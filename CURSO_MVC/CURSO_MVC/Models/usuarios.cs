//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CURSO_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarios
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Passwordd { get; set; }
        public int CodEstado { get; set; }
    
        public virtual estado estado { get; set; }
    }
}
