using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RogueCached.Test
{
    [TestClass]
    public class FileAccessTests
    {
        [TestMethod]
        public void TestKeyValidation()
        {
            var fa = new RogueCached.FileAccess();
            Assert.IsNotNull(fa.GetCacheFilePath("testtest"));
            Assert.IsNotNull(fa.GetCacheFilePath("test/test!"));
            try
            {
                fa.GetCacheFilePath("test~t!est|");
                Assert.Fail();
            }
            catch (Exception) { }
        }
    }
}
