using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductItemViewModel>
        {
            new ProductItemViewModel { Title = "Ürün 1", StartCount = 5, OldPrice = 100.0, Price = 99.90, ImageUrl = "url1", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 2", StartCount = 6, OldPrice = 78.90, Price = 120.0, ImageUrl = "url2", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 3", StartCount = 7, OldPrice = 367.0, Price = 467.0, ImageUrl = "url3", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 4", StartCount = 7, OldPrice = 370.0, Price = 400.0, ImageUrl = "url4", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 5", StartCount = 4, OldPrice = 75.50, Price = 89.00, ImageUrl = "url5", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 6", StartCount = 8, OldPrice = 100.0, Price = 150.0, ImageUrl = "url6", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 7", StartCount = 9, OldPrice = 170.0, Price = 180.0, ImageUrl = "url7", IsSale = true },
            new ProductItemViewModel { Title = "Ürün 8", StartCount = 9, OldPrice = 123.0, Price = 234.0, ImageUrl = "url8", IsSale = true },
        };

            return View(products);
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
}