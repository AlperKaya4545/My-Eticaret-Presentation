using BenimProjem.Business.Services;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BenimProjem.ViewComponents
{
    public class HeaderMiddleViewComponent : ViewComponent
    {
        IProductService _productService;
        public HeaderMiddleViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            HeaderMiddleBasketModel model = new HeaderMiddleBasketModel();
            model.ForBasket = _productService.ProductWithImages().OrderByDescending(x => x.Id).Take(1).ToList();
            
            return View(model);
        }
    }
}
