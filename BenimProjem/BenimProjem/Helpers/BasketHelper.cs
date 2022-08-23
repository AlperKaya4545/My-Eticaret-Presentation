using BenimProjem.Models;
using System;
using System.Linq;

namespace BenimProjem.Helpers
{
    public class BasketHelper
    {
        private static BasketHelper obj = new BasketHelper();


        //baskethelper'ı geri döndürdüğü için içindeki tüm methodlara erişiriz. bir kere de örneklemiş olduk
        public static BasketHelper GetMethods
        {
            get 
            { 
                return obj; 
            }
            
        }


        public void Create(BasketModel basketItem)
        {
            Program.BasketProductList.Add(basketItem);
        }         
        public void AddProduct(BasketProduct product, string cookieCode, int userId,int quantity)
        {
            var basket = Program.BasketProductList.Where(x => x.CookieCode == cookieCode).FirstOrDefault();
            if (basket == null)
            {
                var newBasket = new BasketModel()
                {
                    CookieCode = cookieCode,
                    UserId = userId
                };
                newBasket.BasketProducts.Add(product);
                Create(newBasket);
            }
            else
            {
                if (basket.BasketProducts.Any(x => x.ProductId == product.ProductId))
                {
                    var basketProduct = basket.BasketProducts.FirstOrDefault(x => x.ProductId == product.ProductId);
                    basketProduct.Quantity += quantity;
                }
                else
                {
                    basket.BasketProducts.Add(product);
                }
            }
        }
        public BasketModel Get(string code)
        {
            return Program.BasketProductList.Where(x => x.CookieCode == code).FirstOrDefault();
        }
        public Tuple<int, decimal> GetBasketDetails(string code)
        {
            //tuple aynı anda 2 değer birden döndürmek için kullanılır.
            try
            {
                var basket = Get(code);
                if (basket == null)
                {
                    return null;
                }
                Tuple<int, decimal> result;

                int count = basket.BasketProducts.Sum(x => x.Quantity);
                decimal total = basket.BasketProducts.Sum(x => x.Quantity * x.Product.Price);
                return result = new Tuple<int, decimal>(count, total);
               
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
