using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RogueCached;
using RogueCached.Test.TestObjects;
namespace RogueCached.Test
{
    [TestClass]
    public class FileAccessTests
    {
        [TestMethod]
        public void TestKeyValidation()
        {

            Assert.IsNotNull(CachedFileAccess.GetCacheFilePath("testtest", ""));
            Assert.IsNotNull(CachedFileAccess.GetCacheFilePath("test/test!", ""));
            try
            {
                CachedFileAccess.GetCacheFilePath("test~t!est|", "");
                Assert.Fail();
            }
            catch (Exception) { }
        }

        [TestMethod]
        public void TestSaveAndLoad()
        {
            CachedFile<DummyData> test = new CachedFile<DummyData>();
            test.Key = "test";
            test.Expires = DateTime.Now.AddMinutes(1);
            test.DataCollection = new System.Collections.Generic.Dictionary<string, DummyData>()
            {
                {"test1",new DummyData(){ Key="test1", JunkString="test1s"}},
                {"test2",new DummyData(){ Key="test2", JunkString="test2s"}},
            };

            CachedFileAccess.WriteCache<DummyData>(test, "");

            CachedFile<DummyData> readed = CachedFileAccess.ReadCache<DummyData>("test");

        }
    }
}
