using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    /// <summary>
    /// Set [Serializable] on the inherited object.
    /// </summary>
    public interface ICachedItem //: ISerializable
    {
        string Key { get; set; }
        DateTime LastUpdate { get; set; }
    }
}
