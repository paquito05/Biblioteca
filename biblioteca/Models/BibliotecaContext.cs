using Microsoft.EntityFrameworkCore;


namespace biblioteca.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public  DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.DNI)
                .IsUnique();

            modelBuilder.Entity<Usuario>()
              .Property(p => p.Estado)
              .HasDefaultValue(true);

            modelBuilder.Entity<Prestamo>()
                .Property(p => p.Estado)
                .HasDefaultValue("Activo");


          
        }


    }
}
