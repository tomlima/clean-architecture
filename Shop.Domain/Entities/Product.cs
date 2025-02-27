namespace Shop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required ICollection<Category> Categories { get; set; }
    public required string Image { get; set; }
    public required Brand Brand { get; set; }
    public ICollection<Tag> Tags { get; set; }
}