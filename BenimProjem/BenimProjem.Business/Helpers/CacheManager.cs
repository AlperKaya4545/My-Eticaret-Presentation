using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenimProjem.Business.Helpers
{
    public class CacheManager : ICacheManager
    {
        private readonly IMemoryCache _memoryCache; // memorycache; databaseden cekilen dataların bilgisayarın memorysinde saklanmasını sağlayan bir kütüphane, yani ram'de. Microsoftun kendinden gelen bir kütüphanesi
        public static ConcurrentBag<string> keys = new ConcurrentBag<string>(); // generic listte birden fazla erişim isteği olursa sıraya koyar. Dataları tek tek verir, hata almayı azaltır.

        public CacheManager(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T Get<T>(string key) // getirmek istediğimiz nesnenin tipini söyleyeceğiz <T> type demek.
        {
            var result = _memoryCache.Get<T>(key);
            if (result == null)
            {
                Delete(key);
            }
            return result;
        }

        public void Set(string key, object data) // her tipte datayı object içine atabiliriz.
        {
            RemoveKey(key); // yeni data gelirken eskisi varsa remove siler, yenisini çeker.
            keys.Add(key);
            _memoryCache.Set(key, data);

        }
        public void Delete(string key)
        {
            _memoryCache.Remove(key);   
            RemoveKey(key);
        }

        public void Clear() 
        {
            var list =keys.ToList();
            foreach (var item in list)
            {
                Delete(item);
                RemoveKey(item);
            }
        }

        public void Clear(string header)
        {
            var list = keys.AsQueryable().Where(x => x.StartsWith(header)).ToList();
            foreach (var item in list)
            {
                Delete (item);
                RemoveKey (item);
            }
        }

        private void RemoveKey(string key)
        {
            var data = keys.AsQueryable().Where(x => x == key).FirstOrDefault();
            if (data != null)
            {
                data = null;
            }
        }
    }
}
