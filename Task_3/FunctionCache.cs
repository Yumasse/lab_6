using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class FunctionCache<TKey, TResult>
    {
        private readonly Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();


        public delegate TResult FuncDelegate(TKey key);

        private class CacheItem
        {
            public TResult Result { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

  
        public TResult GetOrAdd(TKey key, FuncDelegate func, TimeSpan expirationTime)
        {
            if (cache.TryGetValue(key, out var cacheItem) && cacheItem.ExpirationTime > DateTime.Now)
            {
                return cacheItem.Result;
            }
            else
            {
                TResult result = func(key);
                cache[key] = new CacheItem { Result = result, ExpirationTime = DateTime.Now.Add(expirationTime) };
                return result;
            }
        }
    }
}
