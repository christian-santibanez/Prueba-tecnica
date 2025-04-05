using InventoryAPI.Models;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> GetAll();
    Task<Categoria?> GetById(int id);
    Task Add(Categoria categoria);
    Task Update(Categoria categoria);
    Task<IEnumerable<Categoria>> GetAllPaginados(int pageNumber, int pageSize);
    Task AddAsync(Categoria categoria);
    Task SaveAsync();
}