using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached.DataAccess
{
    public class BaseChainedDataAccess<T> : IChainedDataAccess<T>
    {
        public IChainedDataAccess<T> Source { get; set; }
        public BaseChainedDataAccess(IChainedDataAccess<T> source)
        {
            Source = source;
        }

        public virtual bool Load(ref T data)
        {
            if (Source != null)
            {
                return Source.Load(ref data);
            }
            return true;
        }

        public virtual bool Save(ref T data)
        {
            if (Source != null)
            {
                return Source.Save(ref data);
            }
            return true;
        }

        public virtual bool Refresh(ref T data)
        {
            if (Source != null)
            {
                return Source.Save(ref data);
            }
            return true;
        }
    }
}
