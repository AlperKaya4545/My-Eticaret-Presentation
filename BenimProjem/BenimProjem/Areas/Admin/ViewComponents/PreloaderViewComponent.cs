using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class PreloaderViewComponent : ViewComponent
    {
        public PreloaderViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
