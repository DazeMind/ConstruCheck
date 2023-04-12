using CCBackend.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CCBackend
{
    public class ccDbContext : DbContext
    {
        public ccDbContext(DbContextOptions<ccDbContext> options): base(options) { }

        public DbSet<AsistenciaModel> Asistencias { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<ComercioModel> Comercios { get; set; }
        public DbSet<ProyectoDiarioModel> Diarios { get; set; }
        public DbSet<PagoModel> Pagos { get; set; }
        public DbSet<ProductoModel> Productos { get; set; }
        public DbSet<IngresoProyectoModel> IngresosProyectos { get; set; }
        public DbSet<GastosProyectoModel> GastosProyectos { get; set; }
        public DbSet<ProyectoModel> Proyectos { get; set; }
        public DbSet<InteresadoProyectoModel> Interesados { get; set; }
        public DbSet<TareaProyectoModel> TareasProyectos { get; set; }
        public DbSet<SemanaProyectoModel> Semanales { get; set; }
        public DbSet<CotizacionModel> Cotizaciones { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TrabajadorModel> Trabajadores { get; set; }


    }
}
