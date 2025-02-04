using Shop.Domain.Entities;

namespace Shop.Infrastructure.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetProducts();
}