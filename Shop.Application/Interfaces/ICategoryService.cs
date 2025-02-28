using Shop.Application.DTOs;

namespace Shop.Application.Interfaces;

public interface ICategoryService
{
    public Task<List<CategoryDTO>> GetCategories();
}