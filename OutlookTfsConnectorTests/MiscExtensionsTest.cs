using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlookTfsConnector;

namespace OutlookTfsConnectorTests
{
    [TestClass]
    public class MiscExtensionsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("", "".GetSafeFileSystemName());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("____", ">< \"".GetSafeFileSystemName());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("", ((string)null).GetSafeFileSystemName());
        }
    }
}
