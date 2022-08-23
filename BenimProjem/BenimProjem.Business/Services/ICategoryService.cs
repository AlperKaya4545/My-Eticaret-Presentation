using BenimProjem.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Services
{
    public interface ICategoryService
    {
        List<Category> List();
        Category GetCategory(string seoName);
    }
}
