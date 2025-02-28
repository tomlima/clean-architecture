using System.Diagnostics;
using Shop.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shop.Web.Models;

namespace Shop.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _productService;
    private readonly ICategoryTypeService _categoryTypeService;
    private readonly ICategoryService _categoryService;

    public HomeController(
        ILogger<HomeController> logger, 
        IProductService productService,
        ICategoryTypeService categoryTypeService,
        ICategoryService categoryService
        )
    {
        _logger = logger;
        _productService = productService;
        _categoryTypeService = categoryTypeService;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetProductsASync();
        var featuredProducts = await _productService.GetFeaturedProducts();
        var categoryTypes = await _categoryTypeService.GetCategoryTypes();
        var categories = await _categoryService.GetCategories();
        
        HomeViewModel model = new HomeViewModel
        {
            Products = products,
            CategoryTypes = categoryTypes,
            Categories = categories,
            FeaturedProducts = featuredProducts
        };  
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}