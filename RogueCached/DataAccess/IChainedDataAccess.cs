using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached.DataAccess
{
    public interface IChainedDataAccess<T> 
    {
        /// <summary>
        /// A source of data that the current object relies on and changes will propagate through.
        /// </summary>
        IChainedDataAccess<T> Source { get; set; }

        /// <summary>
        /// Starts loading data and the highest level and stops when the first True is returned.
        /// </summary>
        /// <param name="data">A rolling collection of data</param>
        /// <returns></returns>
        bool Load(ref T data);//Load data starting at the highest level access layer

        /// <summary>
        /// Starts loading at the deepest level and stops when the first True is returned.
        /// </summary>
        /// <param name="data">A rolling collection of data</param>
        /// <returns></returns>
        bool Refresh(ref T data);

        /// <summary>
        /// Starts saving at the highest level and propagates down.
        /// </summary>
        /// <param name="data">A rolling collection of data</param>
        /// <returns></returns>
        bool Save(ref T data);


    }
}
