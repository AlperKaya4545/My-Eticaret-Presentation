using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class ProductAreaOneViewComponent : ViewComponent
    {
        IProductService _productService;
        public ProductAreaOneViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var products = _productService.ProductWithImages();

            return View(products);
        }
    }
}
