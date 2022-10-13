using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Pelicula>().ToTable("Pelicula");
            modelBuilder.Entity<Personaje>().ToTable("Personaje");
        }

    }

}