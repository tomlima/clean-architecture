using Shop.Domain.Entities;
namespace Shop.Infrastructure.Data;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        // Seed Shops
        if (!context.Brands.Any())
        {
            context.Brands.AddRange(
                new Brand {Name = "Nike"},
                new Brand {Name = "Adidas"},
                new Brand {Name = "Converse"}
            );
            context.SaveChanges();
        }
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product {Name =  "Dunk SB Rayssa Leal", Price = 450, Brand = new Brand() },
                new Product {Name =  "Samsung", Price = 800, Brand = new Brand() },
                new Product {Name =  "Sony", Price = 600, Brand = new Brand() },
                new Product {Name =  "Xbox", Price = 400, Brand = new Brand()},
                new Product {Name =  "Xbox One", Price = 300, Brand = new Brand()}
            );
            context.SaveChanges();
        }
    }
}