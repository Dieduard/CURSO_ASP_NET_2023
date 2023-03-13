using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;      /* HAGO USO DE ESTA LIBRERIA PARA TENER ACCESO DATANOTATIONS */

namespace CURSO_MVC.Models.ViewModel
{
    #region ATRIBUTOS DE LA TABLA USUARIO Y QUE LOS PERMITE AGREGAR LOS DATOS DESDE NUESTRO FORMULARIO Y SUS VALIDACIONES  ...
    public class UsuarioViewModel
    {
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
    }
    #endregion

    #region ATRIBUTOS DE LA TABLA USUARIO Y QUE LOS PERMITE EDITAR LOS DATOS DESDE NUESTRO TABLA POR MEDIO DE NUESTRO FORMULARIO...
    public class EditUsuarioViewModel
    {
        public int Id { get; set; }

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
    }
    #endregion

}


