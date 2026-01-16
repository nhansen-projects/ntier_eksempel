using Microsoft.EntityFrameworkCore;
using ntier.DAL.Interfaces;
using ntier.DataAccess;
using ntier.Models;

namespace ntier.DAL.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }
}
