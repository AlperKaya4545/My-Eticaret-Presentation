using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BenimProjem.Controllers
{
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

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            //IsValid=datalar doğrudur anlamına gelir
            if (ModelState.IsValid)
            {
                var login = _userService.Login(model.Email, model.Password);
                if (login == null)
                {
                    ModelState.AddModelError("LoginError", "Login Failed.");
                }
                else
                {
                    string guid = Guid.NewGuid().ToString();
                    _cookieHelper.Add(CookieTypes.user, guid, DateTime.Now.AddDays(20),Response);
                    _userTicketService.Add(guid, login.Id);
                    return RedirectToAction("Index", "Home"); 
                }
                
            }
            else
            {

            }
            return View();
        }
        public IActionResult Logout()
        {
            _cookieHelper.Delete(CookieTypes.user, Response);
            return RedirectToAction("Index");
        }
    }
}
