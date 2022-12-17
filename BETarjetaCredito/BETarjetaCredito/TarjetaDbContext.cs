using BETarjetaCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace BETarjetaCredito
{
    public class TarjetaDbContext : DbContext
    {
        public DbSet<TarjetaModel> TarjetasCredito { get; set; }
        public TarjetaDbContext (DbContextOptions<TarjetaDbContext> options) : base (options) { }
    }
}
