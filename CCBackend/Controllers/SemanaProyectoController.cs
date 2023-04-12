using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/SemanaProyecto")]
    public class SemanaProyectoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public SemanaProyectoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<SemanaProyectoModel>>> Get()
        {
            return await _thisContext.Semanales.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SemanaProyectoModel>> Get(int id)
        {
            var Semanal = await _thisContext.Semanales.FindAsync(id);
            if (Semanal == null)
            {
                return NotFound();
            }
            return Semanal;
        }

        [HttpPost]
        public async Task<ActionResult<SemanaProyectoModel>> Post(SemanaProyectoModel Semanal)
        {
            _thisContext.Semanales.Add(Semanal);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Semanal.SemanaProyectoId }, Semanal);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int SemanalId)
        {
            var Semanal = await _thisContext.Semanales.FindAsync(SemanalId);
            if (Semanal == null)
            {
                return NotFound();
            }

            _thisContext.Semanales.Remove(Semanal);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
