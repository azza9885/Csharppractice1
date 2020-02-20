using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest2
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a+b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod2()
        {
            var a = 10;
            var b = 10;
            Assert.AreEqual(21, a+b);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.Fail("This method will always fail");
        }
    }
}
