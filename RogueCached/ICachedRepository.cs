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
        void Remove(string key);
        T Get(string key);
        void Save(DateTime expiresAt);
        int Count(Expression<Func<T, bool>> filter = null);
        IQueryable<T> Query(Expression<Func<T, bool>> filter = null);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);

        /* Properties to add:
         * CacheOnly - Only saves/loads from cache
         * FileOnly - Only saves/loads from file
         * MemoryTimelimit - The time it can sit it memory before it is unloaded. The next time it is called it can reload into memory from the file.
         * Expires - The time before both memory and file cache are removed.
         * 
         */
    }
}
