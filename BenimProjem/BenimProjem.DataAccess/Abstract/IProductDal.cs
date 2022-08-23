using BenimProjem.Core.DataAccess;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        List<ProductImagesCustomModel> GetProductsWithImages();
        List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page);
        int CategoryProductCount(int categoryId);   
    }
}
