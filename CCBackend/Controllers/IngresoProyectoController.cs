using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/ingresoProyecto")]
    public class IngresoProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public IngresoProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<IngresoProyectoModel>>> Get()
        {
            return await _thisContext.IngresosProyectos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IngresoProyectoModel>> Get(int id)
        {
            var IngresoProyecto = await _thisContext.IngresosProyectos.FindAsync(id);
            if (IngresoProyecto == null)
            {
                return NotFound();
            }
            return IngresoProyecto;
        }

        [HttpPost]
        public async Task<ActionResult<IngresoProyectoModel>> Post(IngresoProyectoModel IngresoProyecto)
        {
            _thisContext.IngresosProyectos.Add(IngresoProyecto);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = IngresoProyecto.IngresoProyectoId }, IngresoProyecto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int IngresoProyectoId)
        {
            var IngresoProyecto = await _thisContext.IngresosProyectos.FindAsync(IngresoProyectoId);
            if (IngresoProyecto == null)
            {
                return NotFound();
            }

            _thisContext.IngresosProyectos.Remove(IngresoProyecto);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
