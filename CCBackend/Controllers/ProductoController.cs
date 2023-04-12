using CCBackend.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCBackend.Controllers
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoController : ControllerBase
    {
        
        private readonly ccDbContext _thisContext; //crea la variable contexto

        public ProductoController(ccDbContext dbContext)
        {
            _thisContext = dbContext; //inicializa el contexto cuando se llama a la clase
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<ProductoModel>>> Get()
        {
            return await _thisContext.Productos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoModel>> Get(int id)
        {
            var Producto = await _thisContext.Productos.FindAsync(id);
            if (Producto == null)
            {
                return NotFound();
            }
            return Producto;
        }

        [HttpPost]
        public async Task<ActionResult<ProductoModel>> Post(ProductoModel Producto)
        {
            _thisContext.Productos.Add(Producto);
            await _thisContext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = Producto.ProductoId }, Producto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int ProductoId)
        {
            var Producto = await _thisContext.Productos.FindAsync(ProductoId);
            if (Producto == null)
            {
                return NotFound();
            }

            _thisContext.Productos.Remove(Producto);
            await _thisContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
