using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.Areas.Admin.ViewComponents
{
    public class ContentWrapperContainsPageContentViewComponent : ViewComponent
    {
        public ContentWrapperContainsPageContentViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
