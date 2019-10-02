using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data
{
    public class DataContext: DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        /// <summary>
        /// Agregar la entidaeds a la base de datos
        /// </summary>
        public DbSet<Owner> Owners { get; set; }

        public DbSet<PetType> PetTypes { get; set; }

        public DbSet<Pet> Pets { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

        public DbSet<History> Histories { get; set; }

        public DbSet<Agenda> Agendas { get; set; }

    }
}
