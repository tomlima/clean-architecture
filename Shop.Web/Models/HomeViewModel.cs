using Shop.Application.DTOs;
namespace Shop.Web.Models;


public class HomeViewModel
{
    public List<ProductDTO> Products { get; set; }
    public List<CategoryTypeDTO> CategoryTypes { get; set; }
}