using Microsoft.AspNetCore.Mvc;
using ntier.BLL.Interfaces;

namespace ntier.API;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await productService.GetAllProductsAsync();
        return Ok(products);
    }
}