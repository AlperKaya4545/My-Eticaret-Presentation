using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Models
{
    public class ShopViewModel 
    {
        public List<CategoryProductsCustomModel> Products { get; set; }
        public int CurrentPage { get; set; }    
        public int TotalPage { get; set; }
        public string CategoryName { get; set; }    
        
    }
}
