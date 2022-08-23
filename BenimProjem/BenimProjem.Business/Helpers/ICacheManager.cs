using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Helpers
{
    public interface ICacheManager
    {
        T Get <T>(string key); // T generic tip demek
        void Set(string key, object data);
        void Delete(string key);
        void Clear();
        void Clear(string header);

        // memory cache sistemi. cache içindeki dataları nesne olarak tutacağız. Class oluştur içini doldur cacheye gönder. 
        
    }
}
