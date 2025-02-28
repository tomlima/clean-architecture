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

    public HomeController(ILogger<HomeController> logger, IProductService productService, ICategoryTypeService categoryTypeService)
    {
        _logger = logger;
        _productService = productService;
        _categoryTypeService = categoryTypeService;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetProductsASync();
        var categoryTypes = await _categoryTypeService.GetCategoryTypes();
        
        HomeViewModel model = new HomeViewModel
        {
            Products = products,
            CategoryTypes = categoryTypes
        };
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}