using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    public class DataContext: IdentityDbContext<User>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// Agregar la entidad Owners a la base de datos
        /// </summary>
        public DbSet<Owner> Owners { get; set; }

        /// <summary>
        /// Agregar la entidad PetTypes a la base de datos
        /// </summary>
        public DbSet<PetType> PetTypes { get; set; }

        /// <summary>
        /// Agregar la entidad Pets a la base de datos
        /// </summary>
        public DbSet<Pet> Pets { get; set; }

        /// <summary>
        /// Agregar la entidad ServiceTypes a la base de datos
        /// </summary>
        public DbSet<ServiceType> ServiceTypes { get; set; }

        /// <summary>
        /// Agregar la entidad Histories a la base de datos
        /// </summary>
        public DbSet<History> Histories { get; set; }

        /// <summary>
        /// Agregar la entidad Agendas a la base de datos
        /// </summary>
        public DbSet<Agenda> Agendas { get; set; }

        /// <summary>
        /// Agregar la entidad Manager a la base de datos
        /// </summary>
        public DbSet<Manager> Managers { get; set; }

    }
}
