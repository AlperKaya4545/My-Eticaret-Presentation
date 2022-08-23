using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using BenimProjem.Entites;
using BenimProjem.Helpers;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BenimProjem.Controllers
{
    public class CheckoutController : Controller
    {
        IOrderService _orderService;
        ICookieHelper _cookieHelper;

        public CheckoutController(IOrderService orderService, ICookieHelper cookieHelper)
        {
            _orderService = orderService;
            _cookieHelper = cookieHelper;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CheckoutViewModel model)
        {
            if (model == null)
            {
                return RedirectToAction("Home", "Index");
            }
            if (ModelState.IsValid)
            {
                Order ord = new Order();
                ord.Address = model.Addres;
                ord.City = Convert.ToInt32(model.City);
                ord.Date = DateTime.Now;
                ord.FirstName = model.FirstName;    
                ord.LastName = model.LastName; 
                ord.Phone = model.Phone;
                var ticket = _cookieHelper.Get(CookieTypes.basket, Request);
                var basket = BasketHelper.GetMethods.GetBasketDetails(ticket);
                var orderJson = Newtonsoft.Json.JsonConvert.SerializeObject(basket);

                ord.OrderDetail = orderJson;
                //Json
                _orderService.Add(ord);
                return RedirectToAction("Checkout", "OrderOk");

            }
            return View();
        }
    }
}
