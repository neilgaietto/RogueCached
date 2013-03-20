using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RogueCached.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //RogueCached.CachedRepository<TestObjects.DummyData> testRep = new RogueCached.CachedRepository<TestObjects.DummyData>("dummydata", System.Web.HttpRuntime.Cache);
            TestObjects.DummyDataRepository dd = new TestObjects.DummyDataRepository("dummydata", System.Web.HttpRuntime.Cache);
            
        }
    }
}
