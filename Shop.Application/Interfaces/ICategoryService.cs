using Shop.Domain.Entities;

namespace Shop.Application.Interfaces;

public interface ICategoryService
{
    public Task<List<Category>> GetCategories();
}