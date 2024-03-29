﻿// =====================================================================================
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
        public User User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Pet> Pets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Agenda> Agendas { get; set; }
    }
}
