using Shop.Domain.Entities;
using Shop.Infrastructure.Data;
using Shop.Infrastructure.Interfaces;

namespace Shop.Infrastructure.Repositories;

public class ProductRepository:IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProducts()
    {
        return _context.Products.ToList();
    }

    public async Task<List<Product>> GetFeaturedProducts()
    {
        return _context.Products.Where(p => p.Featured == true).ToList();
    }
}