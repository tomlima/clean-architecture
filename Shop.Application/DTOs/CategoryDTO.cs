namespace Shop.Application.DTOs;
using Shop.Domain.Entities;

public class CategoryDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryType Type { get; set; }
}   