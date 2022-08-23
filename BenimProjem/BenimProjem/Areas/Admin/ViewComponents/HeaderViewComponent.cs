using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class HeaderViewComponent : ViewComponent
    {
        public HeaderViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
