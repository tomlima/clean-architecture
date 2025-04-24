using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace Shop.Infrastructure.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var webProjectDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..", "Shop.Web");
        // Build the configuration pointing to 'Shop.Web/appsettings.json'
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(webProjectDirectory)  
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();


        // The connection string
        string? connectionString = configuration.GetConnectionString("DefaultConnection");
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseMySQL(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}