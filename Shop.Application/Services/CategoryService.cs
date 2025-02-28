using Shop.Application.Interfaces;
using Shop.Domain.Entities;
using Shop.Infrastructure.Interfaces;

namespace Shop.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Category>> GetCategories()
    {
        return await _categoryRepository.GetCategories();
    }
}