using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;      /* HAGO USO DE ESTA LIBRERIA PARA TENER ACCESO DATANOTATIONS */

namespace CURSO_MVC.Models.ViewModel
{
    public class UsuarioViewModel
    {
        #region ATRIBUTOS QUE LOS SIRVE PARA AGREGAR TODOS LOS DATOS DE NUESTRO USUARIO EN EL FORMULARIO ...

        [Required]                                /* ESTO QUIERE DECIR QUE ESTE CAMPO ES REQUERIDO */
        [EmailAddress]                            /* ESTO QUIERE DECIR QUE VALIDA QUE TENGA LA ESTRUCTURA DE UN CORREO */
        [Display(Name = "(Correo Electronico)")]   /* AQUI LE PONEMOS POR NOMBRE CORREO ELETRO....*/
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos:", MinimumLength = 1)] /*CANTIDAD CARACTERES QUE NECESITA */
        public string Email { get; set; }

        [Required]                                /* ATRIBUTO REQUERIDO */
        [DataType(DataType.Password)]             /* DECIMOS CON ESTO QUE LA CONTRASEÑA VAYA INCRIPTADA  */
        [Display(Name = "(Contraseña)")]
        public string Password { get; set; }

        [Display(Name = "(Confirmar Contraseña)")]                            /* AQUI PONEMOS POR NOMBRE CONFIRMAR CON...*/
        [DataType(DataType.Password)]                                         /* CONTRASEÑA VA INCRIPTADA  */
        [Compare("Password", ErrorMessage = "Las contraseñas NO son iguales")] /* AQUI HACE UNA COMPARATIVA CON PASSWORD */
        public string ConfirPassword { get; set; }

        [Required]                                /* ATRIBUTO REQUERIDO */
        public int Edad { get; set; }
        #endregion
    }

    public class EditUsuarioViewModel
    {
        #region ATRIBUTOS QUE LOS SIRVE PARA AGREGAR TODOS LOS DATOS DE NUESTRO USUARIO EN EL FORMULARIO ...

        [Required]                                /* ESTO QUIERE DECIR QUE ESTE CAMPO ES REQUERIDO */
        [EmailAddress]                            /* ESTO QUIERE DECIR QUE VALIDA QUE TENGA LA ESTRUCTURA DE UN CORREO */
        [Display(Name = "(Correo Electronico)")]   /* AQUI LE PONEMOS POR NOMBRE CORREO ELETRO....*/
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos:", MinimumLength = 1)] /*CANTIDAD CARACTERES QUE NECESITA */
        public string Email { get; set; }

        [DataType(DataType.Password)]             /* DECIMOS CON ESTO QUE LA CONTRASEÑA VAYA INCRIPTADA  */
        [Display(Name = "(Contraseña)")]
        public string Password { get; set; }

        [Display(Name = "(Confirmar Contraseña)")]                            /* AQUI PONEMOS POR NOMBRE CONFIRMAR CON...*/
        [DataType(DataType.Password)]                                         /* CONTRASEÑA VA INCRIPTADA  */
        [Compare("Password", ErrorMessage = "Las contraseñas NO son iguales")] /* AQUI HACE UNA COMPARATIVA CON PASSWORD */
        public string ConfirPassword { get; set; }

        [Required]                                /* ATRIBUTO REQUERIDO */
        public int Edad { get; set; }
        #endregion
    }
}


