using Microsoft.EntityFrameworkCore;
using ParqueoAPI.Models;

namespace ParqueoAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<EspacioParqueo> EspaciosParqueo { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
