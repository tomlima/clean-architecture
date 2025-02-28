using Shop.Domain.Entities;

namespace Shop.Infrastructure.Repositories;

public class CategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Category>> GetCategories()
    {
        return _context.Categories.ToList();
    }
}