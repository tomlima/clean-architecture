using Shop.Application.DTOs;


namespace Shop.Application.Interfaces;

public interface ICategoryTypeService
{
    Task<List<CategoryTypeDTO>> GetCategoryTypes(); 
}