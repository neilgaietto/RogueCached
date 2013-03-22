using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace RogueCached
{
    [Serializable]
    public class CachedRepository<T> : ICachedRepository<T> where T: ICachedItem// where T : class, new()
    {
        public string Key { get; set; }
        private Cache Context { get; set; }
        private Dictionary<string, T> DataCollection { get; set; }

        public CachedRepository(string key, Cache cacheContext)
        {
            Key = key;
            Context = cacheContext;
            DataCollection = Context[Key] as Dictionary<string, T>;

            if (DataCollection != null)
            {
                //remove expired
            }
            if (DataCollection == null)
            {
                //create empty collection
                DataCollection = new Dictionary<string, T>();
            }

        }


        // Adds or Updates
        public void Add(T entity)
        {
            DataCollection.Add(entity.Key, entity);
        }

        public void Remove(string key)
        {
            if (key == null) { return; }
            DataCollection.Remove(key);
        }

        public void Save(DateTime expiresAt)
        {
            Context[Key] = DataCollection;
        }

        public T Get(string key)
        {
            return DataCollection[key];
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter = null)
        {

            IQueryable<T> query = DataCollection.Values.AsQueryable();
            if (filter != null)
                query = query.Where(filter);
            return query;
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return DataCollection.Values.AsQueryable().SingleOrDefault(predicate);
        }

        public int Count(Expression<Func<T, bool>> filter = null)
        {
            return Query(filter).Count();
        }


    }
}
