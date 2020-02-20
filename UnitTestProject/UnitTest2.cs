using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod2()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a + b);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.Fail("This method will always fail");
        }
    }
}
