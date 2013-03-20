﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace RogueCached.Test.TestObjects
{
    public class DummyDataRepository : CachedRepository<DummyData>
    {
        public DummyDataRepository(string key, Cache context)
            : base(key, context)
        {

        }
    }
}