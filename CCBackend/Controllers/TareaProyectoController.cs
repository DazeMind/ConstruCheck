using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/tareaProyecto")]
    public class TareaProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public TareaProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<TareaProyectoModel>>> Get()
        {
            return await _thisContext.TareasProyectos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TareaProyectoModel>> Get(int id)
        {
            var TareaProyecto = await _thisContext.TareasProyectos.FindAsync(id);
            if (TareaProyecto == null)
            {
                return NotFound();
            }
            return TareaProyecto;
        }

        [HttpPost]
        public async Task<ActionResult<TareaProyectoModel>> Post(TareaProyectoModel TareaProyecto)
        {
            _thisContext.TareasProyectos.Add(TareaProyecto);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = TareaProyecto.TareaProyectoId }, TareaProyecto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int TareaProyectoId)
        {
            var TareaProyecto = await _thisContext.TareasProyectos.FindAsync(TareaProyectoId);
            if (TareaProyecto == null)
            {
                return NotFound();
            }

            _thisContext.TareasProyectos.Remove(TareaProyecto);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
