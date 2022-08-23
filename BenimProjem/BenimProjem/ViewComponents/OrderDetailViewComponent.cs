using BenimProjem.Business.Helpers;
using BenimProjem.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class OrderDetailViewComponent : ViewComponent
    {
        ICookieHelper _cookieHelper;
        public OrderDetailViewComponent(ICookieHelper cookieHelper)
        {
            _cookieHelper = cookieHelper;
        }
        public IViewComponentResult Invoke()
        {
            var ticketKey = _cookieHelper.Get(CookieTypes.basket, Request);
            var basket = BasketHelper.GetMethods.Get(ticketKey);

            return View(basket);  
        }
    }
}
