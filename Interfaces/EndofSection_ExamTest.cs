using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces
{
    [TestClass]
    public class EndofSection_ExamTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Console.WriteLine(pageObject1.PageName);
            Assert.AreEqual("Page Name 1", pageObject1.PageName);

        }

        [TestMethod]
        public void TestMethod2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Console.WriteLine(pageObject2.PageName);
            Assert.AreEqual("Page Name 2", pageObject2.PageName);

        }
    }
}
