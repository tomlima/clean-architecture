using Shop.Application.DTOs;
using Shop.Application.Interfaces;
using Shop.Infrastructure.Interfaces;


namespace Shop.Application.Services;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<ProductDTO>> GetProductsASync()
    {
        var products = await _productRepository.GetProducts();
        return products.Select(p => new ProductDTO
        {   
            Id = p.Id,
            Name = p.Name,
            Price = p.Price,
        }).ToList();
    }

    public async Task<List<ProductDTO>> GetFeaturedProducts()
    {
        var products = await _productRepository.GetProducts();
        return products.Select(p => new ProductDTO
        {   
            Id = p.Id,
            Name = p.Name,
            Price = p.Price,
            Image = p.Image,
        }).ToList();
    }
}