using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Utility u = new Utility();
            Assert.AreEqual(7, u.sum(3, 4));
        }
    }
}
