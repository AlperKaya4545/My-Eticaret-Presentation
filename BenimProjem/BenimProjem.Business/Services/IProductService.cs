using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public interface IProductService
    {
        List<ProductImagesCustomModel> ProductWithImages();
        Product Get(string seoName);
        void CountUp(Product product);
        Product Get(int id);
        List<CategoryProductsCustomModel> GetCategoryProducts(int categoryId, int? page);
        
        int TotalPage(int categoryId);
        List<Product> List();
    }
}
