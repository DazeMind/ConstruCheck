using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/interesadoProyecto")]
    public class InteresadoProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public InteresadoProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<InteresadoProyectoModel>>> Get()
        {
            return await _thisContext.Interesados.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InteresadoProyectoModel>> Get(int id)
        {
            var Interesado = await _thisContext.Interesados.FindAsync(id);
            if (Interesado == null)
            {
                return NotFound();
            }
            return Interesado;
        }

        [HttpPost]
        public async Task<ActionResult<InteresadoProyectoModel>> Post(InteresadoProyectoModel Interesado)
        {
            _thisContext.Interesados.Add(Interesado);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Interesado.InteresadoProyectoId }, Interesado);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int InteresadoId)
        {
            var Interesado = await _thisContext.Interesados.FindAsync(InteresadoId);
            if (Interesado == null)
            {
                return NotFound();
            }

            _thisContext.Interesados.Remove(Interesado);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
