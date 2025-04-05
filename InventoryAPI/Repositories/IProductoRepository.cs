
public interface IProductoRepository {
    Task<IEnumerable<Producto>> GetAllPaginados(int pageNumber, int pageSize);
    void Insert(Producto producto);
}