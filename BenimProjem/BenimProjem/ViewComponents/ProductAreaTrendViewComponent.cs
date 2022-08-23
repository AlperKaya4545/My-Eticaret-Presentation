using BenimProjem.Business.Services;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BenimProjem.ViewComponents
{
    public class ProductAreaTrendViewComponent : ViewComponent
    {
        IProductService _productService;
        public ProductAreaTrendViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            ProductTrendAreaViewModel model = new ProductTrendAreaViewModel();
            model.NewProducts = _productService.ProductWithImages().OrderByDescending(x => x.Id).Take(4).ToList();
            model.MostView = _productService.ProductWithImages().OrderByDescending(x => x.Counter).Take(4).ToList();


            return View(model);  
        }
    }
}
