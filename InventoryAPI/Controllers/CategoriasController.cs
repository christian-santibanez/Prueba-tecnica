using Microsoft.AspNetCore.Mvc;
using InventoryAPI.Models;
using InventoryAPI.DTOs;

namespace InventoryAPI.Controllers
{
    /// <summary>
    /// Controlador para gestionar operaciones de categorías
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriasController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        /// <summary>
        /// Obtiene todas las categorías paginadas
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetAll(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            var categorias = await _categoriaRepository.GetAllPaginados(pageNumber, pageSize);
            return Ok(categorias);
        }

        /// <summary>
        /// Crea una nueva categoría
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CategoriaCreateDto dto)
        {
            var categoria = new Categoria
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion
            };

            await _categoriaRepository.AddAsync(categoria);
            await _categoriaRepository.SaveAsync();

            return Ok(new { Message = "Categoría creada exitosamente", Id = categoria.Id });
        }
    }
}