using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class HeaderBottomViewComponent : ViewComponent
    {
        ICategoryService _categoryService;
        public HeaderBottomViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var result = _categoryService.List();
            return View(result);
        }
    }
}
