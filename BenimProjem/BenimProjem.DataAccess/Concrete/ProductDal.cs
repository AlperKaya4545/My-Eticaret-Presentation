using BenimProjem.Core.DataAccess;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.DataAccess.Concrete
{
    public class ProductDal : RepositoryBase<Product, BenimProjemContext>, IProductDal
    {
        public List<ProductImagesCustomModel> GetProductsWithImages()
        {
            using (BenimProjemContext c = new BenimProjemContext()) // using içinde new'lenen nesneler using dışına cıktığı zaman newlemedeki nesne tamamen silinir. Db context newliyorsak using kullanmak zorundayız
            {
                // Products içindeki p yi birleştir p yi productimagede, productid ile eşitle
                // p product tablosunu temsil , pi productimageyi temsil ediyor.
                var result = (from p in c.Products
                              join pi in c.ProductImages
                              on p.Id equals pi.ProductId
                              select new ProductImagesCustomModel
                              {
                                  Description = p.Description,
                                  Id = p.Id,
                                  Image = pi.Name,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName,
                                  Status = p.Status,

                              }).ToList();
                return result;
                // 2-3 tablodan gerekirse bunu yapıyoruz.
            }
        }
        public List<CategoryProductsCustomModel> GetCategoryProduct(int categoryId, int? page)
        {
            int pageProductCount = 12;
            int takeProduct = 0;
            if (page == null || page == 1)
            {
                takeProduct = 0;
            }
            else
            {
                takeProduct = (pageProductCount * (page.Value - 1));
            }
            using (BenimProjemContext c = new BenimProjemContext())
            {
                var result = (from p in c.Products
                              join cp in c.CategoryProducts
                              on p.Id equals cp.ProductId
                              select new CategoryProductsCustomModel
                              {
                                  Status = p.Status,
                                  Sort = cp.Sort,
                                  Counter = p.Counter,
                                  Description = p.Description,
                                  Id = p.Id,
                                  Name = p.Name,
                                  Price = p.Price,
                                  SeoName = p.SeoName
                              }
                              ).OrderBy(x => x.Sort).ToList();
                result = result.Skip(takeProduct).Take(pageProductCount).ToList();
                return result;
            }
        }

        public int CategoryProductCount(int categoryId)
        {
            using (var c = new BenimProjemContext())
            {
                return c.CategoryProducts.Count(x => x.CategoryId == categoryId);
            }
        }
    }
}
