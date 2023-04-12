using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/gastosProyecto")]
    public class GastosProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public GastosProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<GastosProyectoModel>>> Get()
        {
            return await _thisContext.GastosProyectos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GastosProyectoModel>> Get(int id)
        {
            var GastosProyecto = await _thisContext.GastosProyectos.FindAsync(id);
            if (GastosProyecto == null)
            {
                return NotFound();
            }
            return GastosProyecto;
        }

        [HttpPost]
        public async Task<ActionResult<GastosProyectoModel>> Post(GastosProyectoModel GastosProyecto)
        {
            _thisContext.GastosProyectos.Add(GastosProyecto);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = GastosProyecto.GastosProyectoId }, GastosProyecto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int GastosProyectoId)
        {
            var GastosProyecto = await _thisContext.GastosProyectos.FindAsync(GastosProyectoId);
            if (GastosProyecto == null)
            {
                return NotFound();
            }

            _thisContext.GastosProyectos.Remove(GastosProyecto);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
