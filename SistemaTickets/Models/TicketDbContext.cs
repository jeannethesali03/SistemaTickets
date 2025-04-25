using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;

namespace SistemaTickets.Models
{
    public class TicketDbContext:DbContext
    {
        public TicketDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
    }
}
