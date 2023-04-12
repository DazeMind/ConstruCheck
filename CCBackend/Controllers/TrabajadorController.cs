using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/trabajador")]
    public class TrabajadorController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public TrabajadorController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<TrabajadorModel>>> Get()
        {
            return await _thisContext.Trabajadores.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrabajadorModel>> Get(int id)
        {
            var Trabajador = await _thisContext.Trabajadores.FindAsync(id);
            if (Trabajador == null)
            {
                return NotFound();
            }
            return Trabajador;
        }

        [HttpPost]
        public async Task<ActionResult<TrabajadorModel>> Post(TrabajadorModel Trabajador)
        {
            _thisContext.Trabajadores.Add(Trabajador);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Trabajador.TrabajadorId }, Trabajador);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int TrabajadorId)
        {
            var Trabajador = await _thisContext.Trabajadores.FindAsync(TrabajadorId);
            if (Trabajador == null)
            {
                return NotFound();
            }

            _thisContext.Trabajadores.Remove(Trabajador);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
