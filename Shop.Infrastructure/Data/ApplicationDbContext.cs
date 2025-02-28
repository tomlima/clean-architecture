using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
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
    public DbSet<Category> Categories { get; set; } 
    public DbSet<Tag> Tags { get; set; }
    public DbSet<CategoryType> CategoryTypes { get; set; }
}