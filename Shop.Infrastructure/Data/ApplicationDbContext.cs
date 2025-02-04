using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSets for your entities
    public DbSet<Product> Products { get; set; }
    
    public DbSet<Brand> Brands { get; set; }
}