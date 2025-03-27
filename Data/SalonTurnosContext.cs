using Microsoft.EntityFrameworkCore;
using SalonTurnos.Api.Models;

namespace SalonTurnos.Api.Data
{
    public class SalonTurnosContext : DbContext
    {
        public SalonTurnosContext(DbContextOptions<SalonTurnosContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
