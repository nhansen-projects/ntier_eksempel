using ntier.BLL.Interfaces;
using ntier.DAL.Interfaces;
using ntier.Models;

namespace ntier.BLL;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _productRepository.GetAllAsync();
    }
}