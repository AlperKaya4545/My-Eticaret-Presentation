using BenimProjem.Business.Helpers;
using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public class ProductService : IProductService
    {
        IProductDal _productDal;
        private readonly ICategoryDal _categoryDal;
        ICacheManager _cacheManager;
        IProductImageDal _productImageDal;

        public ProductService(IProductDal productDal, ICacheManager cacheManager, ICategoryDal categoryDal, IProductImageDal productImageDal)
        {
            _productDal = productDal;
            _cacheManager = cacheManager;
            _categoryDal = categoryDal;
            _productImageDal = productImageDal;
        }

        public void CountUp(Product product)
        {
            product.Counter = product.Counter + 1;
            _productDal.Update(product);
        }

        public Product Get(string seoName)
        {
            return _productDal.Get(x => x.SeoName == seoName);
        }

        public Product Get(int id)
        {
            return _productDal.Get(x =>x.Id == id);
        }

        public List<CategoryProductsCustomModel> GetCategoryProducts(int categoryId, int? page)
        {
            var result = _productDal.GetCategoryProduct(categoryId, page);
            var images = _productImageDal.List();
            result.ForEach(x => x.Image = images.First(i => i.ProductId == x.Id).Name);

            return result;
        }

        public List<ProductImagesCustomModel> ProductWithImages()
        {
            var cacheData = _cacheManager.Get<List<ProductImagesCustomModel>>("productwithimage.all");
            if (cacheData == null)
            {
                var result = _productDal.GetProductsWithImages();
                _cacheManager.Set("productwithimage.all", result);
                return result;
            }
            else
            {
                return cacheData;
            }
        }

        public int TotalPage(int categoryId)
        {
            var productCount = _productDal.CategoryProductCount(categoryId);
            var modResult = productCount % 12; //  bir sayfada görünecek ürün 
            if (modResult > 0)
            {
                return ((productCount - modResult) / 12) + 1;
            }
            else
            {
                return productCount / 12;
            }
        }

        public List<Product> List()
        {
            return _productDal.List();
        }
    }
}
