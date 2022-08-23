using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Helpers 
{
    public class CookieHelper : ICookieHelper
    {
        public void Add(CookieTypes name, string value, DateTime expiredDate, HttpResponse response)
        {
            response.Cookies.Append(name.ToString(), value, new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(10)
            });
        }

        public string Get(CookieTypes name,HttpRequest request)
        {
            try
            {
                return request.Cookies[name.ToString()];
            }
            catch (Exception)
            {

                return null;
            }
        }
        public void Delete(CookieTypes name,HttpResponse response)
        {
            Add(name, "", DateTime.Now.AddYears(-30),response);
        }
    }
}
