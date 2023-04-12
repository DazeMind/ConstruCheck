using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public UsuarioController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<UsuarioModel>>> Get()
        {
            return await _thisContext.Usuarios.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> Get(int id)
        {
            var Usuario = await _thisContext.Usuarios.FindAsync(id);
            if (Usuario == null)
            {
                return NotFound();
            }
            return Usuario;
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Post(UsuarioModel Usuario)
        {
            _thisContext.Usuarios.Add(Usuario);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Usuario.UsuarioId }, Usuario);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int UsuarioId)
        {
            var Usuario = await _thisContext.Usuarios.FindAsync(UsuarioId);
            if (Usuario == null)
            {
                return NotFound();
            }

            _thisContext.Usuarios.Remove(Usuario);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
