using CCBackend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CCBackend
{
    public class ccDbContext : DbContext
    {
        public ccDbContext(DbContextOptions<ccDbContext> options): base(options) { }

        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<WorkersModel> Trabajadores { get; set; }
        public DbSet<AttendanceModel> Asistencias { get; set; }
        public DbSet<PaymentsModel> Pagos { get; set; }


    }
}
