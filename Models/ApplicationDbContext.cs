using PruebaTecnica_PasajeInteligente.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica_PasajeInteligente.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>()
                .HasKey(e => e.Id); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
