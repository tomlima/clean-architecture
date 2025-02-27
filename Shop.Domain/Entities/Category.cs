namespace Shop.Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    
    public required CategoryType CategoryType { get; set; }
}   