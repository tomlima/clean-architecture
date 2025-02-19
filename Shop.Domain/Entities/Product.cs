namespace Shop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required Category Category { get; set; }
    public required string Image { get; set; }
    public required Brand Brand { get; set; }
    
    public required ICollection<Tag> Tags { get; set; }
}