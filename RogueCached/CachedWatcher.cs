using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace RogueCached
{
    //checks every few minutes for rogue caches that need expired
    public class CachedWatcher : ICachedWatcher
    {
        private Dictionary<string,Type> CacheKeys;

        private Cache Context { get; set; }

        public CachedWatcher(Cache cacheContext)
        {
            CacheKeys = new Dictionary<string, Type>();
            Context = cacheContext;
        }

        public void Watch(string cacheKey, Type type)
        {
            if (Context[cacheKey] != null)
            {
                CacheKeys.Add(cacheKey, type);
            }
        }

        public void Expire(string cacheKey)
        {
            
        }

        public void ClearAll()
        {
            foreach (var key in CacheKeys.Keys)
            {
                Context.Remove(key);
            }
        }

        public int Count()
        {
            return CacheKeys.Count;
        }


        public void ClearExpired()
        {
            foreach (var item in CacheKeys)
            {item.
                var cached = (Context[item.Key]);
                
                if (cached == null)
                {
                    Context.Remove(key);
                }
            }
        }
    }
}
