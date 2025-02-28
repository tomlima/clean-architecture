using Shop.Domain.Entities;
namespace Shop.Infrastructure.Data;

public class DbInitializer
{
    public static void Seed(ApplicationDbContext context)
    {
        // Initializing category types
        CategoryType CT_modality = new CategoryType { Name = "Modality" };
        CategoryType CT_gender = new CategoryType { Name = "Gender" };
        CategoryType CT_type = new CategoryType { Name = "Type" };
        
        
        // Initializing brands
        Brand B_nike = new Brand { Name = "Nike" };
        Brand B_adidas = new Brand { Name = "Adidas" };
        Brand B_salomon = new Brand { Name = "Salomon" };
        
        
        // Initializing categories
        Category C_casual = new Category { Name = "Casual" , CategoryType = CT_modality };
        Category C_running = new Category { Name = "Running", CategoryType = CT_modality };
        Category C_skate = new Category {Name = "Skate", CategoryType = CT_modality };
        Category C_gym = new Category {Name = "Gym", CategoryType = CT_modality };
        Category C_hiking = new Category {Name = "Hiking", CategoryType = CT_modality };
        Category C_female = new Category {Name = "Female", CategoryType = CT_gender };
        Category C_male = new Category {Name = "Male", CategoryType = CT_gender };
        Category C_unisex = new Category {Name = "Unisex", CategoryType = CT_gender };
        Category C_sneaker = new Category {Name = "Sneaker", CategoryType = CT_type };
        Category C_boot = new Category {Name = "Boot", CategoryType = CT_type };


        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product
                {
                    Name = "Nike Revolution 7",
                    Price = 70,
                    Categories = new List<Category> { C_casual, C_unisex, C_sneaker },
                    Image = "nike-revolution-7",
                    Brand = B_nike,
                    Featured = true
                },
                new Product
                {
                    Name = "Nike Downshifter 13",
                    Price = 76,
                    Categories = new List<Category> { C_gym, C_male, C_sneaker },
                    Image = "nike-downshifter-13",
                    Brand = B_nike,
                    Featured = false
                },
                new Product
                {
                    Name = "Adidas Grand Court Base",
                    Price = 50,
                    Categories = new List<Category> { C_running, C_gym, C_male, C_sneaker },
                    Image = "adidas-grand-court-base",
                    Brand = B_adidas,
                    Featured = true
                },
                new Product
                {
                    Name = "Adidas Grand Court Base", 
                    Price = 55,
                    Categories = new List<Category> { C_running, C_gym, C_male, C_sneaker },
                    Image = "adidas-grand-court-base",
                    Brand = B_adidas,
                    Featured = false
                },
                new Product
                {
                    Name = "Adidas Duramo Rc",
                    Price = 40,
                    Categories = new List<Category> { C_running, C_gym, C_female, C_sneaker },
                    Image = "adidas-duramo-rc",
                    Brand = B_adidas,
                    Featured = false 
                },
                new Product
                {
                    Name = "Salomon Quest Element GTX",
                    Price = 250, 
                    Categories = new List<Category> { C_hiking,C_male,C_boot},
                    Image = "salomon-quest-element-gtx",
                    Brand = B_salomon,
                    Featured = true 
                },
                new Product
                {
                    Name = "Salomon X Ultra 360 MID GTX",
                    Price = 260,
                    Categories = new List<Category> { C_hiking,C_female, C_boot },
                    Image = "salomon-xultra-360-mid-gtx-",
                    Brand = B_salomon,
                    Featured = false
                }
            );
            context.SaveChanges();
        }
    }
}