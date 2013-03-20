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
    public abstract class CachedRepository<T> : ICachedRepository<T> where T: ICachedItem// where T : class, new()
    {
        public string Key { get; set; }
        private Cache Context;// = new T();


        protected CachedRepository(string key, Cache context)
        {
            Key = key;
            Context = context;
        }

        //protected CachedRepository(string key)
        //{
        //    CachedRepository(key, HttpRuntime.Cache);
        //}

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

    }
}
