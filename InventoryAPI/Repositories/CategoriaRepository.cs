using Microsoft.EntityFrameworkCore;
using InventoryAPI.Models;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;

    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Categoria>> GetAllPaginados(int pageNumber, int pageSize)
    {
        return await _context.Categorias
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<Categoria?> GetById(int id)
    {
        return await _context.Categorias.FindAsync(id);
    }

    public async Task Add(Categoria categoria)
    {
        await _context.Categorias.AddAsync(categoria);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Categoria categoria)
    {
        _context.Entry(categoria).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Categoria>> GetAll()
    {
        return await _context.Categorias.ToListAsync();
    }

    public async Task AddAsync(Categoria categoria)
    {
        await _context.Categorias.AddAsync(categoria);
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}