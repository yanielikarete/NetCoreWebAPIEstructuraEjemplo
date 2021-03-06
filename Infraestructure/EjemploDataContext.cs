using Microsoft.EntityFrameworkCore;
using EjemploAyuda.Models;
using EjemploAyuda.Infraestructure.EntityConfigurations;
using EjemploAyuda.Domain.Models;

namespace EjemploAyuda.Infraestructure
{
    public class EjemploDataContext : DbContext
    {
        public DbSet<Tutorial> Tutoriales { get; set; }
        public DbSet<Autor> Autores {get; set;}

        public EjemploDataContext(DbContextOptions<EjemploDataContext> options) 
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TutorialEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AutorEntityConfiguration());
        }
    }
}