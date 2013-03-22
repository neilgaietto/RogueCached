using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace RogueCached.DataAccess
{
    public class CacheAccess<T>: BaseChainedDataAccess<T> where T : class
    {
        public string Key { get; set; }
        public Cache Context { get; set; }
        public CacheAccess(string key, IChainedDataAccess<T> source) :base(source)
        {
            Key = key;
            Context = HttpRuntime.Cache;
        }

        public override bool Load(ref T data)
        {
            //if we find data in cache, then return it and end load chain
            T t = Context[Key] as T;
            if (t != null)
            {
                data = t;
                return true;
            }

            return base.Load(ref data);
        }

        public override bool Save(ref T data)
        {
            //save data to cache
            Context[Key] = data;
            return base.Save(ref data);
        }

        public override bool Refresh(ref T data)
        {
            //if the deeper Refresh returned false then try pulling data, otherwise skip
            //if we dont have data then return false
            bool r = base.Refresh(ref data);
            if (!r)
            {
                T t = Context[Key] as T;
                if (t != null)
                {
                    data = t;
                    return true;
                }
            }
            return false;
        }
    }
}
