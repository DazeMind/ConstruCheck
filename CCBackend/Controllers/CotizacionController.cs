using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/cotizacion")]
    public class CotizacionController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public CotizacionController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<CotizacionModel>>> Get()
        {
            return await _thisContext.Cotizaciones.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CotizacionModel>> Get(int id)
        {
            var Cotizacion = await _thisContext.Cotizaciones.FindAsync(id);
            if (Cotizacion == null)
            {
                return NotFound();
            }
            return Cotizacion;
        }

        [HttpPost]
        public async Task<ActionResult<CotizacionModel>> Post(CotizacionModel Cotizacion)
        {
            _thisContext.Cotizaciones.Add(Cotizacion);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Cotizacion.CotizacionId }, Cotizacion);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int CotizacionId)
        {
            var Cotizacion = await _thisContext.Cotizaciones.FindAsync(CotizacionId);
            if (Cotizacion == null)
            {
                return NotFound();
            }

            _thisContext.Cotizaciones.Remove(Cotizacion);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
