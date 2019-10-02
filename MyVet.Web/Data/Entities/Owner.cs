// =====================================================================================
// Desarrollado Por		    : Juan Carlos Guerrero Maldonado.
// Fecha de Creación		: 29 Septiembre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Data.Entities.Owner.cs
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Entity for Owners
// =====================================================================================
// MODIFICACIONES:
// =====================================================================================
// Ver.	Fecha		    Autor – Empresa                     Descripción
// ---	-------------	---------------------------------   ----------------------------
// =====================================================================================
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyVet.Web.Data.Entities
{
    public class Owner
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

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
        [Display(Name = "Fixed Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string FixedPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Cell Phone")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string CellPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// 
        /// </summary>
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        /// <summary>
        /// Relacion con la tabla Pet uno a muchos
        /// </summary>
        public ICollection<Pet> Pets { get; set; }

        /// <summary>
        /// Relacion con la tabla Agenda uno a muchos
        /// </summary>
        public ICollection<Agenda> Agendas { get; set; }

    }
}
