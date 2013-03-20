using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    public interface ICachedRepository<T> : IQueryable<T>
    {
        string Key { get; set; }
        void Add(T entity);
        T Get(string id);
        void Remove(T entity);
    }
}
