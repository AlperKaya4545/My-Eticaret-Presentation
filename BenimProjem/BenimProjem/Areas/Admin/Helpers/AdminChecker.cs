using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Http;
using BenimProjem.Entites;
using Microsoft.EntityFrameworkCore;

namespace BenimProjem.Areas.Admin.Helpers
{
    public class AdminChecker : IAdminChecker
    {

        ICookieHelper _cookieHelper;
        IUserService _userService;
        IUserTicketService _userTicketService;
        

        public AdminChecker(ICookieHelper cookieHelper, IUserService userService, IUserTicketService userTicketService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTicketService = userTicketService;
        }
        public bool Check(HttpRequest request)
        {
            
            var ticketId = _cookieHelper.Get(CookieTypes.admin, request);            
            if (ticketId != null)
            {
                var ticket = _userTicketService.Get(ticketId);
                if (ticket != null)
                {
                    var userId = ticket.UserId;
                    var user = _userService.GetById(userId);
                    if (user.IsAdmin) return true;
                  
                }
                               
            }
            return false;
            //return true;
        }        
    }
}
