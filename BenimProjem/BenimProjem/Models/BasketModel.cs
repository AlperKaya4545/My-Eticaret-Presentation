using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Models
{
    public class BasketModel
    {
        public BasketModel()
        {
            BasketProducts = new List<BasketProduct>(); 
        }
        public int? UserId { get; set; } // int? yani null yaparak kullanıcıya giriş yapmadan da ekleme imkanı
        public string CookieCode { get; set; }
        public List<BasketProduct> BasketProducts { get; set; } 
    }
    public class BasketProduct // basket içindeki ürün bilgilerini burda tutuyoruz
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        
    }
}
