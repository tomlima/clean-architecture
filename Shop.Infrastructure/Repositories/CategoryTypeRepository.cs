using Shop.Domain.Entities;
using Shop.Infrastructure.Interfaces;

namespace Shop.Infrastructure.Repositories;

public class CategoryTypeRepository : ICategoryTypeRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryTypeRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<CategoryType>> GetCategoryTypes()
    {
        return  _context.CategoryTypes.ToList();
    }
}