// =====================================================================================
// Desarrollado Por		    : Juan Carlos Guerrero Maldonado.
// Fecha de Creación		: 02 Octubre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Models.LoginViewModel.cs
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Entity for Owners
// =====================================================================================
// MODIFICACIONES:
// =====================================================================================
// Ver.	Fecha		    Autor – Empresa                     Descripción
// ---	-------------	---------------------------------   ----------------------------
// =====================================================================================
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
