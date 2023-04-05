using CCBackend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CCBackend
{
    public class ccDbContext : DbContext
    {
        public ccDbContext(DbContextOptions<ccDbContext> options): base(options) { }

        public DbSet<AttendanceModel> Asistencias { get; set; }
        public DbSet<ClientModel> Clientes { get; set; }
        public DbSet<CommerceModel> Comercio { get; set; }
        public DbSet<DailyProyectModel> Diarios { get; set; }
        public DbSet<PaymentsModel> Pagos { get; set; }
        public DbSet<ProductModel> Productos { get; set; }
        public DbSet<ProjectEntryModel> IngresosProyectos { get; set; }
        public DbSet<ProjectExpenditureModel> GastosProyectos { get; set; }
        public DbSet<ProjectModel> Proyectos { get; set; }
        public DbSet<ProjectResponsibleModel> Interesados { get; set; }
        public DbSet<ProjectTaskModel> TareasProyectos { get; set; }
        public DbSet<ProjectWeekModel> Semanales { get; set; }
        public DbSet<RateModel> Cotizaciones { get; set; }
        public DbSet<UserModel> Usuarios { get; set; }
        public DbSet<WorkerModel> Trabajadores { get; set; }


    }
}
