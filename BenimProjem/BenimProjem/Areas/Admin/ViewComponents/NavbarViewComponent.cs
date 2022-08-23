using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class NavbarViewComponent : ViewComponent
    {
        public NavbarViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
