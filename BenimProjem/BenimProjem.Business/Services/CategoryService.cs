using BenimProjem.DataAccess.Abstract;
using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetCategory(string seoName)
        {
            // /category/shop
            return _categoryDal.Get(x => x.SeoName == seoName);
        }

        public List<Category> List()
        {
            var result = _categoryDal.List();  
            return result;  
        }
    }
}
