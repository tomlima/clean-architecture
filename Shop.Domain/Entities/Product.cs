namespace Shop.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public required List<Category> Categories { get; set; }
    public required string Image { get; set; }
    public required Brand Brand { get; set; }
    public List<Tag> Tags { get; set; }
    public required bool Featured { get; set; } = false;
}