using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenimProjem.ViewComponents
{
    public class HeaderTopViewComponent : ViewComponent
    {
        IUserService _userService;
        IUserTicketService _userTicketService;
        ICookieHelper _cookieHelper;
        public HeaderTopViewComponent(IUserService userService, IUserTicketService userTicketService, ICookieHelper cookieHelper)
        {
            _userService = userService;
            _userTicketService = userTicketService;
            _cookieHelper = cookieHelper;
        }
        public IViewComponentResult Invoke()
        {
            var cookie = _cookieHelper.Get(CookieTypes.user, Request);
            
            var ticketDetail = _userTicketService.Get(cookie);

            if (cookie == null || ticketDetail == null)
            {
                ViewData["email"] = null;
            }
            else  
            {
                ViewData["email"] = _userService.GetById(ticketDetail.UserId).Email; //Atıp geri çekeceğiz. Control view arası data tasıyoruz.Componentin html'ine datayı çekiyoruz. 
            }            
            return View();
        }
    }
}
