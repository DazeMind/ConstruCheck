using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/comercio")]
    public class ComercioController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public ComercioController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<ComercioModel>>> Get()
        {
            return await _thisContext.Comercios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ComercioModel>> Get(int id)
        {
            var Comercio = await _thisContext.Comercios.FindAsync(id);
            if (Comercio == null)
            {
                return NotFound();
            }
            return Comercio;
        }

        [HttpPost]
        public async Task<ActionResult<ComercioModel>> Post(ComercioModel Comercio)
        {
            _thisContext.Comercios.Add(Comercio);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Comercio.ComercioId }, Comercio);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ComercioId)
        {
            var Comercio = await _thisContext.Comercios.FindAsync(ComercioId);
            if (Comercio == null)
            {
                return NotFound();
            }

            _thisContext.Comercios.Remove(Comercio);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
