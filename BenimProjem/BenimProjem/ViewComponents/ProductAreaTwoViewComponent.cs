using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class ProductAreaTwoViewComponent : ViewComponent
    {
        public ProductAreaTwoViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
