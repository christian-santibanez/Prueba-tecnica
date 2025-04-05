using Microsoft.AspNetCore.Mvc;
using InventoryAPI.Services;

namespace InventoryAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase {
        private readonly ProductoService _service;

        public ProductosController(ProductoService service) {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10) {
            await _service.GetAll(pageNumber, pageSize);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductoCreateDto dto) {
            try {
                await _service.CreateProducto(dto);
                return Ok("Producto creado");
            } catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}