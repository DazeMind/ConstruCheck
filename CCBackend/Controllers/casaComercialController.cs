using CCBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/casacomercial/")]
    public class casaComercial : ControllerBase
    {
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public casaComercial(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        //GET ALL
        [HttpGet]
        public async Task<ActionResult<IEnumerable<casaComercialModel>>> Get()
        {
            return await _thisContext.cc_casa_comercial.ToListAsync(); //cc_casa_comercial es la variable que esta en dbSet del contexto
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<ActionResult<casaComercialModel>> Get(int id)
        {
            var casaComercial = await _thisContext.cc_casa_comercial.FindAsync(id);

            if (casaComercial == null)
            {
                return NotFound();
            }

            return casaComercial;
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<casaComercialModel>> Post(casaComercialModel casaComercial)
        {
            try
            {
                _thisContext.cc_casa_comercial.Add(casaComercial);
                await _thisContext.SaveChangesAsync();

                return CreatedAtAction(nameof(Get), new { id = casaComercial.id }, casaComercial);

            }catch (Exception ex) {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Ha ocurrido un error guardado los datos. No se han realizado cambios");

            }
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, casaComercialModel casaComercial)
        {
            if (id != casaComercial.id)
            {
                return BadRequest();
            }

            _thisContext.Entry(casaComercial).State = EntityState.Modified;
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var casaComercial = await _thisContext.cc_casa_comercial.FindAsync(id);

            if (casaComercial == null)
            {
                return NotFound();
            }

            _thisContext.cc_casa_comercial.Remove(casaComercial);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
