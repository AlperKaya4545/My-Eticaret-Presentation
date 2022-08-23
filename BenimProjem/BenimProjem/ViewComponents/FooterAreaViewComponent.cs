using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class FooterAreaViewComponent : ViewComponent
    {
        public FooterAreaViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
