using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    public interface ICachedWatcher
    {
        void Watch(string cacheKey);
        void Expire(string cacheKey);
        void ClearExpired();
        void ClearAll();
        int Count();
    }
}
