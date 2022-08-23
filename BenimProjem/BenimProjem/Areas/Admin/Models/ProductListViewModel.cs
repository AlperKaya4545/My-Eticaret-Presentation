using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Areas.Admin.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
