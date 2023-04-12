using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/proyecto")]
    public class ProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public ProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<ProyectoModel>>> Get()
        {
            return await _thisContext.Proyectos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoModel>> Get(int id)
        {
            var Proyecto = await _thisContext.Proyectos.FindAsync(id);
            if (Proyecto == null)
            {
                return NotFound();
            }
            return Proyecto;
        }

        [HttpPost]
        public async Task<ActionResult<ProyectoModel>> Post(ProyectoModel Proyecto)
        {
            _thisContext.Proyectos.Add(Proyecto);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Proyecto.ProyectoId }, Proyecto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ProyectoId)
        {
            var Proyecto = await _thisContext.Proyectos.FindAsync(ProyectoId);
            if (Proyecto == null)
            {
                return NotFound();
            }

            _thisContext.Proyectos.Remove(Proyecto);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
