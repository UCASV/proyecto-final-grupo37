using Microsoft.EntityFrameworkCore;
using Proyecto_P3.Entitys.Ciudadanos;

namespace Parcial02.Context
{
    public class Parcial02Context : DbContext
    {
        public DbSet<Ciudadano> Ciudadanos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=DESKTOP-D82P45T;Database=Banco_de_datos;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudadano>().Property(s => s.Dui).ValueGeneratedOnAdd();
            modelBuilder.Entity<Ciudadano>().HasKey(s => s.Dui);
        }

    }
}