using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/asistencia")]
    public class AsistenciaController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public AsistenciaController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<AsistenciaModel>>> Get()
        {
            return await _thisContext.Asistencias.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AsistenciaModel>> Get(int id)
        {
            var Asistencia = await _thisContext.Asistencias.FindAsync(id);
            if (Asistencia == null)
            {
                return NotFound();
            }
            return Asistencia;
        }

        [HttpPost]
        public async Task<ActionResult<AsistenciaModel>> Post(AsistenciaModel Asistencia)
        {
            _thisContext.Asistencias.Add(Asistencia);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Asistencia.AsistenciaId }, Asistencia);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int AsistenciaId)
        {
            var Asistencia = await _thisContext.Asistencias.FindAsync(AsistenciaId);
            if (Asistencia == null)
            {
                return NotFound();
            }

            _thisContext.Asistencias.Remove(Asistencia);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
