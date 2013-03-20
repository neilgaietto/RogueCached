using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    public interface ICachedItem
    {
        string Key { get; set; }
        DateTime LastUpdate { get; set; }
    }
}
