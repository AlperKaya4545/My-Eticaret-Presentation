using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class ProductAreaThreeViewComponent : ViewComponent
    {
        IProductService _productService;
        public ProductAreaThreeViewComponent(IProductService productService)
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
