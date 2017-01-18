using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace RogueCached.Test.TestObjects
{
    public class DummyDataRepository : ICachedRepository<DummyData>
    {
        public DummyDataRepository()
        { }
        public string Key
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Add(DummyData entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public DummyData Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Save(DateTime? expiresAt = null)
        {
            throw new NotImplementedException();
        }

        public int Count(System.Linq.Expressions.Expression<Func<DummyData, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<DummyData> Query(System.Linq.Expressions.Expression<Func<DummyData, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public DummyData SingleOrDefault(System.Linq.Expressions.Expression<Func<DummyData, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
