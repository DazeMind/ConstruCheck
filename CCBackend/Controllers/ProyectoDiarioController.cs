using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/ProyectoDiario")]
    public class ProyectoDiarioController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public ProyectoDiarioController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<ProyectoDiarioModel>>> Get()
        {
            return await _thisContext.Diarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoDiarioModel>> Get(int id)
        {
            var Diaro = await _thisContext.Diarios.FindAsync(id);
            if (Diaro == null)
            {
                return NotFound();
            }
            return Diaro;
        }

        [HttpPost]
        public async Task<ActionResult<ProyectoDiarioModel>> Post(ProyectoDiarioModel Diaro)
        {
            _thisContext.Diarios.Add(Diaro);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Diaro.ProyectoDiarioId }, Diaro);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int DiaroId)
        {
            var Diaro = await _thisContext.Diarios.FindAsync(DiaroId);
            if (Diaro == null)
            {
                return NotFound();
            }

            _thisContext.Diarios.Remove(Diaro);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
