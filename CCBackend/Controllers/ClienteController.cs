using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public ClienteController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<ClienteModel>>> Get()
        {
            return await _thisContext.Clientes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteModel>> Get(int id)
        {
            var Client = await _thisContext.Clientes.FindAsync(id);
            if (Client == null)
            {
                return NotFound();
            }
            return Client;
        }

        [HttpPost]
        public async Task<ActionResult<ClienteModel>> Post(ClienteModel Cliente)
        {
            _thisContext.Clientes.Add(Cliente);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Cliente.ClienteId }, Cliente);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ClienteId)
        {
            var Cliente = await _thisContext.Clientes.FindAsync(ClienteId);
            if (Cliente == null)
            {
                return NotFound();
            }

            _thisContext.Clientes.Remove(Cliente);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
