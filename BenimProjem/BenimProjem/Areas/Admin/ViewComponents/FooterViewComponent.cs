using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    [Area("Admin")]
    public class FooterViewComponent : ViewComponent
    {
        public FooterViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
