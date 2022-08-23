using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class StaticHomeViewComponent : ViewComponent
    {
        public StaticHomeViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
