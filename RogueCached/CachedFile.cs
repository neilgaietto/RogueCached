using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    [Serializable]
    public class CachedFile<T>
    {
        public string Key { get; set; }
        public DateTime Expires { get; set; }
        public Dictionary<string, T> DataCollection { get; set; }
    }
}
