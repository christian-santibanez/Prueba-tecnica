// ProductoRepository.cs
using Microsoft.EntityFrameworkCore;

namespace InventoryAPI.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetAllPaginados(int pageNumber, int pageSize)
        {
            return await _context.Productos
                .Include(p => p.Categoria)  
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public void Insert(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }
    }
}