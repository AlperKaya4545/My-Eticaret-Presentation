using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Models
{
    public class ProductViewModel
    {
        public Product ProductDetail { get; set; }
        public List<ProductImage> Images { get; set; }

    }
}
