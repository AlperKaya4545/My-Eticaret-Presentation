using BenimProjem.Areas.Admin.Models;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        IProductService _productService;
        IProductImageService _productImageService;
        public ProductController(IProductService productService, IProductImageService productImageService)
        {
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            var product = _productService.List();
            ProductListViewModel products = new();
            products.ProductImages = _productImageService.List();
            products.Products = product;

            return View(products);
        }
    }
}
