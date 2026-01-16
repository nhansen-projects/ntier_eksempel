using ntier.Models;

namespace ntier.DAL.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllAsync();
}
