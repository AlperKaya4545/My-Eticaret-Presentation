using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public interface IProductImageService
    {
        List<ProductImage> GetImages(int productId);
        List<ProductImage> List(int productId = 0);
    }
}
