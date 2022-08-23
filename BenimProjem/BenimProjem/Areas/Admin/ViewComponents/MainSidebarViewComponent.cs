using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class MainSidebarViewComponent : ViewComponent
    {
        public MainSidebarViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
