using BenimProjem.Entites;
using System.Collections.Generic;

namespace BenimProjem.Models
{
    public class HeaderMiddleBasketModel : Product
    {
        public List<ProductImagesCustomModel> ForBasket { get; set; }
    }
}
