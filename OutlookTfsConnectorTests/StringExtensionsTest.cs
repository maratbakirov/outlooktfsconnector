using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutlookTfsConnector;

namespace OutlookTfsConnectorTests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("", "".GetFileName());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("____", ">< \"".GetFileName());
        }
    }
}
