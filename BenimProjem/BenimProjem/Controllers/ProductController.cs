using BenimProjem.Business.Services;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IProductImageService _productImageService;

        public ProductController(IProductService productService, IProductImageService productImageService)
        {
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index(string name)
        {
            var product = _productService.Get(name);
            if (product == null) return RedirectToRoute("default");

            var images = _productImageService.GetImages(product.Id);
            ProductViewModel model = new ProductViewModel 
            {
                // ekstra data ihtiyacı oldugu zaman productviewmodele ekleyip buraya da yazıyoruz
                ProductDetail = product,
                Images = images
            };
            _productService.CountUp(product);
            return View(model);   
        }
    }
}
