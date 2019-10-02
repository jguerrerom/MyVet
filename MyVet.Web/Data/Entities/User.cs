// =====================================================================================
// Desarrollado Por		    : Juan carlos Guerrero Maldonado.
// Fecha de Creación		: 02 Octubre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Data.Entities
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Componente entidad para la tabla User que hereda de IdentityUser
// =====================================================================================
// MODIFICACIONES:
// =====================================================================================
// Ver.	Fecha		    Autor – Empresa                     Descripción
// ---	-------------	---------------------------------   ---------------------------
//
// =====================================================================================
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyVet.Web.Data.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "First Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Full Name")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
