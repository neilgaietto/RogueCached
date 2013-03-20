using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached.Test.TestObjects
{
    [Serializable]
    public class DummyData: ICachedItem
    {
        public string JunkString { get; set; }
        public int[] JunkArray { get; set; }

        public string Key { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
