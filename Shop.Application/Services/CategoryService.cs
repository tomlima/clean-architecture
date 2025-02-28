using Shop.Application.Interfaces;
using Shop.Domain.Entities;
using Shop.Infrastructure.Interfaces;
using Shop.Application.DTOs;
using Shop.Domain.Entities;

namespace Shop.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<CategoryDTO>> GetCategories()
    {
        var categories = await _categoryRepository.GetCategories();
        return categories.Select(category => new CategoryDTO
        {   
            Id = category.Id,
            Name = category.Name,
            CategoryType = category.CategoryType
        }).ToList();
    }
}