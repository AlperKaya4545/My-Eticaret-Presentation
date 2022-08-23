using BenimProjem.Areas.Admin.Models;
using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BenimProjem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        ICookieHelper _cookieHelper;
        IUserService _userService;
        IUserTicketService _userTicketService;
        public HomeController(ICookieHelper cookieHelper, IUserService userService, IUserTicketService userTicketService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
            _userTicketService = userTicketService;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminLoginModel model)
        {
            if (ModelState.IsValid)
            {
                var login = _userService.AdminLogin(model.Email, model.Password);
                if (login == null)
                {
                    ModelState.AddModelError("LoginError", "Login Failed.");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.admin, guid, DateTime.Now.AddDays(20), Response);
                    _userTicketService.Add(guid, login.Id);
                    return RedirectToAction("Index", "Dashboard");
                }

            }
            else
            {

            }
            return View();
        }
    }
}
