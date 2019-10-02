// =====================================================================================
// Desarrollado Por		    : Juan Carlos Guerrero Maldonado.
// Fecha de Creación		: 02 Octubre 2019
// Lenguaje Programación	: C#
// Producto o sistema	    : MyVet.Web.Data.Entities.Manager.cs
// =====================================================================================
// Versión	 Descripción
// [1.0.0.0] Entity for Managers
// =====================================================================================
// MODIFICACIONES:
// =====================================================================================
// Ver.	Fecha		    Autor – Empresa                     Descripción
// ---	-------------	---------------------------------   ----------------------------
// =====================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class Manager
    {
        /// <summary>
        /// Id that identifies the Manager
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public User User { get; set; }

    }
}
