using ntier.Models;

namespace ntier.BLL.Interfaces;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
