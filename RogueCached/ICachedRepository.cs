using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RogueCached
{
    public interface ICachedRepository<T>// : IQueryable<T>
    {
        string Key { get; set; }
        void Add(T entity);
        void Remove(T entity);
        T Get(string id);
        void Save();
        int Count(Expression<Func<T, bool>> filter = null);
        IQueryable<T> Query(Expression<Func<T, bool>> filter = null);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
    }
}
