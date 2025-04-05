using InventoryAPI.Models;

namespace InventoryAPI.Services
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Categoria>> GetAllPaginados(int pageNumber, int pageSize)
        {
            return await _repository.GetAllPaginados(pageNumber, pageSize);
        }
    }
}
