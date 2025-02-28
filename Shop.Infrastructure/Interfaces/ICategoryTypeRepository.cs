using Shop.Domain.Entities;

namespace Shop.Infrastructure.Interfaces;

public interface ICategoryTypeRepository
{
    Task<List<CategoryType>> GetCategoryTypes();
}