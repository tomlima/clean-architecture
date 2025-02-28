using Shop.Application.DTOs;
using Shop.Application.Interfaces;
using Shop.Domain.Entities;
using Shop.Infrastructure.Interfaces;

namespace Shop.Application.Services;

public class CategoryTypeService: ICategoryTypeService
{
    private readonly ICategoryTypeRepository _categoryTypeRepository;

    public CategoryTypeService(ICategoryTypeRepository categoryTypeRepository)
    {
        _categoryTypeRepository = categoryTypeRepository;
    }

    public async Task<List<CategoryTypeDTO>> GetCategoryTypes()
    {
        var categoryTypes = await _categoryTypeRepository.GetCategoryTypes();
        return categoryTypes.Select(p => new CategoryTypeDTO
        {   
            Id = p.Id,
            Name = p.Name,
        }).ToList();
    }
}