using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FariñoRosasProyect.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Puedes agregar configuraciones adicionales aquí si es necesario
        }
    }
}

