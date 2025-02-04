using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Shop.Infrastructure.Data;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseMySQL("server=localhost; port=3306; database=ecommerce; user=root; password=root; Persist Security Info=False; Connect Timeout=300");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}