using Shop.Domain.Entities;

namespace Shop.Infrastructure.Interfaces;

public interface ICategoryRepository
{
    public Task<List<Category>> GetCategories();
}