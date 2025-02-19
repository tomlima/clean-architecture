using Shop.Domain.Entities;
namespace Shop.Infrastructure.Data;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product
                {
                    Name =  "Nike Revolution 7", 
                    Price = 299,
                    Category = new Category {Name = "tenis"},
                    Image = "nike-revolution-7",
                    Brand = new Brand {Name = "Nike"},
                    Tags = new List<Tag>
                    {
                        new Tag {Name = "Nike"},
                        new Tag {Name = "Masculino"},
                        new Tag {Name = "Esportivo"},
                    }
                }
            );
            context.SaveChanges();
        }
    }
}