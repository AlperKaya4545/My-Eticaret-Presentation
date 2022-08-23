using BenimProjem.Business.Helpers;
using BenimProjem.Business.Services;
using BenimProjem.Helpers;
using BenimProjem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BenimProjem.Controllers
{
    public class BasketController : Controller
    {
        ICookieHelper _cookieHelper;
        IProductService _productService;
        IProductImageService _productImageService;

        public BasketController(ICookieHelper cookieHelper, IProductService productService, IProductImageService productImageService)
        {
            _cookieHelper = cookieHelper;
            _productService = productService;
            _productImageService = productImageService;
        }

        public IActionResult Index()
        {
            var guidKey = GetGuid();
            var basketDetail = BasketHelper.GetMethods.Get(guidKey);
            BasketIndexViewModel model = new();
            model.Basket = basketDetail;

            return View(model);
        }
        public JsonResult AddBasket(int quantityData, int productIdData)
        {
            //bir siteye giriş yapmasa bile insanları tanımak için cookie'den tanırız.
            string basketGuid = null; // boş bir basketguid oluşturduk
            // cookiesi yoksa cookie oluşturduk, varsa else'le cookieden gelen valueyi değişkene atıp aşağıda kullanabiliyoruz.
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(30), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            var product = _productService.Get(productIdData); // id getirtik sepete eklerken
            var productImages = _productImageService.GetImages(productIdData); // resim getirdik sepete eklerken

            BasketHelper.GetMethods.AddProduct(new BasketProduct
            {
                Image = productImages.First().Name,
                ProductId = productIdData,
                Quantity = quantityData,
                Product = product


            }, basketGuid, 0, quantityData);

            var products = BasketHelper.GetMethods.Get(basketGuid);
            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            // bu yazdığımız sağ üstteki sepete ekleme işlemi yaptığımız yer.
            string basketHtml = $"<span class=\"item-icon\"></span><span class=\"item-text\">{basketDetail.Item2}<span class=\"cart-item-count\">{basketDetail.Item1}</span></span>";
            //basketHtml += "<span></span>";
            //basketHtml += "<div class=\"minicart\">";
            //basketHtml += " <ul class=\"minicart-product-list\">";
            //foreach (var item in products.BasketProducts)
            //{
            //    basketHtml += "<li>";
            //    basketHtml += "<a href=\"single-product.html\" class=\"minicart-product-image\">";
            //    basketHtml += "<img src=\"images/product/small-size/5.jpg\" alt=\"cart products\">";
            //    basketHtml += "</a>";
            //    basketHtml += "<div class=\"minicart-product-details\">";
            //    basketHtml += "<h6><a href=\"single-product.html\">"+item.Product.Name+"</a></h6>";
            //    basketHtml += "<span>£40 x 1</span>";
            //    basketHtml += "</div>";
            //    basketHtml += "<button class=\"close\" title=\"Remove\">";
            //    basketHtml += "<i class=\"fa fa-close\"></i>";
            //    basketHtml += "</button>";
            //    basketHtml += " </li>";
            //}
            

            //basketHtml += " </ul>";
            //basketHtml += " <p class=\"minicart-total\">SUBTOTAL: <span>£80.00</span></p>";
            //basketHtml += "  <div class=\"minicart-button\">";
            //basketHtml += "   <a href =\"shopping-cart.html\" class=\"li-button li-button-fullwidth li-button-dark\">";
            //basketHtml += "     <span>View Full Cart</span>";
            //basketHtml += "</a>";
            //basketHtml += " <a href =\"checkout.html\" class=\"li-button li-button-fullwidth\">";
            //basketHtml += " <span>Checkout</span>";
            //basketHtml += "</a>";
            //basketHtml += "</div>";
            //basketHtml += "</div>";
            return Json(basketHtml);
        }

        public JsonResult GetProductBasket(int quantityData, int productIdData)
        {
            
            string basketGuid = null; 
            
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(30), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            var product = _productService.Get(productIdData); // id getirtik sepete eklerken
            var productImages = _productImageService.GetImages(productIdData); // resim getirdik sepete eklerken

            BasketHelper.GetMethods.AddProduct(new BasketProduct
            {
                Image = productImages.First().Name,
                ProductId = productIdData,
                Quantity = quantityData,
                Product = product


            }, basketGuid, 0, quantityData);

            var products = BasketHelper.GetMethods.Get(basketGuid);
            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            
            string basketHtml = $"basketHtml += <span></span>";
            basketHtml += "<div class=\"minicart\">";
            basketHtml += " <ul class=\"minicart-product-list\">";
            foreach (var item in products.BasketProducts)
            {
                basketHtml += "<li>";
                basketHtml += "<a href=\"single-product.html\" class=\"minicart-product-image\">";
                basketHtml += "<img src=\"images/product/small-size/5.jpg\" alt=\"cart products\">";
                basketHtml += "</a>";
                basketHtml += "<div class=\"minicart-product-details\">";
                basketHtml += "<h6><a href=\"single-product.html\">" + item.Product.Name + "</a></h6>";
                basketHtml += "<span>£40 x 1</span>";
                basketHtml += "</div>";
                basketHtml += "<button class=\"close\" title=\"Remove\">";
                basketHtml += "<i class=\"fa fa-close\"></i>";
                basketHtml += "</button>";
                basketHtml += " </li>";
            }


            basketHtml += " </ul>";
            basketHtml += " <p class=\"minicart-total\">SUBTOTAL: <span>£80.00</span></p>";
            basketHtml += "  <div class=\"minicart-button\">";
            basketHtml += "   <a href =\"shopping-cart.html\" class=\"li-button li-button-fullwidth li-button-dark\">";
            basketHtml += "     <span>View Full Cart</span>";
            basketHtml += "</a>";
            basketHtml += " <a href =\"/basket/index\" class=\"li-button li-button-fullwidth\">";
            basketHtml += " <span>Checkout</span>";
            basketHtml += "</a>";
            basketHtml += "</div>";
            basketHtml += "</div>"; 

            return Json(basketHtml);
        }
        public JsonResult GetBasket()
        {
            string basketGuid = null;
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(30), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }

            var basketDetail = BasketHelper.GetMethods.GetBasketDetails(basketGuid);
            if (basketDetail == null)
            {
                return Json($"<span class=\"item-icon\"></span><span class=\"item-text\">0<span class=\"cart-item-count\">0</span></span>");
            }
            string basketHtml = $"<span class=\"item-icon\"></span><span class=\"item-text\">{basketDetail.Item2}<span class=\"cart-item-count\">{basketDetail.Item1}</span></span>";
            return Json(basketHtml);
        }
        private string GetGuid()
        {
            string basketGuid = null; // boş bir basketguid oluşturduk
                                      // cookiesi yoksa cookie oluşturduk, varsa else'le cookieden gelen valueyi değişkene atıp aşağıda kullanabiliyoruz.
            var basketCookieValue = _cookieHelper.Get(CookieTypes.basket, Request);
            if (basketCookieValue == null)
            {
                basketGuid = Guid.NewGuid().ToString();
                _cookieHelper.Add(CookieTypes.basket, basketGuid, DateTime.Now.AddDays(30), Response);
            }
            else
            {
                basketGuid = basketCookieValue;
            }
            return basketGuid;
        }
        public IActionResult Incqtybutton(int Id)
        {
            var ticket = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(ticket);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);
            if (product.Quantity == 1)
            {
                products.BasketProducts.Remove(product);
            }
            else
            {
                product.Quantity += -1;
            }
            return Redirect("mybasket");

        }
        public IActionResult Decqtybutton(int Id)
        {
            var ticket = _cookieHelper.Get(CookieTypes.basket, Request);
            var products = BasketHelper.GetMethods.Get(ticket);
            var product = products.BasketProducts.FirstOrDefault(p => p.ProductId == Id);

            product.Quantity += 1;

            return Redirect("/mybasket");
        }
    }
}
