using BenimProjem.Business.Services;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;


namespace BenimProjem.Controllers
{
    public class ShopController : Controller
    {
        ICategoryService _categoryService;
        IProductService _productService;

        public ShopController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IActionResult Index(string name, int? page)
        {
            var category = _categoryService.GetCategory(name);
            if (category == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var products = _productService.GetCategoryProducts(category.Id, page);
            ShopViewModel model = new()
            {
                Products = products,
                CurrentPage = page ?? 1,
                TotalPage = _productService.TotalPage(category.Id),
                CategoryName = name
            };
            return View(model);
        }
    }
}
