// InventoryAPI

namespace InventoryAPI.Services
{
    public class ProductoService
    {
        private readonly IProductoRepository _productoRepo;
        private readonly ICategoriaRepository _categoriaRepo;

        public ProductoService(
            IProductoRepository productoRepo, 
            ICategoriaRepository categoriaRepo)
        {
            _productoRepo = productoRepo;
            _categoriaRepo = categoriaRepo;
        }

        public Task CreateProducto(ProductoCreateDto dto)
        {
            // Validate the DTO
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "El DTO no puede ser nulo.");
            }
            var producto = new Producto
            {
                Codigo = dto.Codigo,
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio,
                Stock = dto.Stock,
                CategoriaId = dto.CategoriaId,
                Categoria = null! 
            };

            _productoRepo.Insert(producto);
            return Task.CompletedTask;
        }

        internal Task GetAll(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}