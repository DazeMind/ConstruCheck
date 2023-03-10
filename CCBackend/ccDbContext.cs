using CCBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CCBackend
{
    public class ccDbContext : DbContext
    {
        public ccDbContext(DbContextOptions<ccDbContext> options): base(options) { }

        public DbSet<casaComercialModel> cc_casa_comercial { get; set; }
    }
}
