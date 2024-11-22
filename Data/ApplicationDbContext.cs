using Microsoft.EntityFrameworkCore;
using test3.Data.CompiledModels;
using test3.Models;  // Asegúrate de que el espacio de nombres sea correcto

namespace test3.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura tus modelos directamente aquí
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired();
                // Otros ajustes de configuración
            });
        }
    }
}