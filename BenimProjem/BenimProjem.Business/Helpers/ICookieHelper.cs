using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace BenimProjem.Business.Helpers
{
    public interface ICookieHelper
    {
        void Add(CookieTypes name, string value,DateTime expiredDate,HttpResponse response);
        string Get(CookieTypes name, HttpRequest request);
        void Delete(CookieTypes name,HttpResponse response);
    }
}
