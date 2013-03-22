using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RogueCached.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestCount()
        {
            //RogueCached.CachedRepository<TestObjects.DummyData> testRep = new RogueCached.CachedRepository<TestObjects.DummyData>("dummydata", System.Web.HttpRuntime.Cache);
            //TestObjects.DummyDataRepository dd = new TestObjects.DummyDataRepository("dummydata", System.Web.HttpRuntime.Cache);
            RogueCached.CachedRepository<TestObjects.DummyData> testRep = new RogueCached.CachedRepository<TestObjects.DummyData>("dummydata", System.Web.HttpRuntime.Cache);
            testRep.Add(new TestObjects.DummyData() { Key = "test1", JunkString = "teststring1" });
            testRep.Add(new TestObjects.DummyData() { Key = "test2", JunkString = "teststring2" });
            Assert.AreEqual(2, testRep.Count());
        }
    }
}
