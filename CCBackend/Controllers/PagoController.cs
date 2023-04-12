using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/pago")]
    public class PagoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public PagoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<PagoModel>>> Get()
        {
            return await _thisContext.Pagos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PagoModel>> Get(int id)
        {
            var Pago = await _thisContext.Pagos.FindAsync(id);
            if (Pago == null)
            {
                return NotFound();
            }
            return Pago;
        }

        [HttpPost]
        public async Task<ActionResult<PagoModel>> Post(PagoModel Pago)
        {
            _thisContext.Pagos.Add(Pago);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Pago.PagoId }, Pago);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int PagoId)
        {
            var Pago = await _thisContext.Pagos.FindAsync(PagoId);
            if (Pago == null)
            {
                return NotFound();
            }

            _thisContext.Pagos.Remove(Pago);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
