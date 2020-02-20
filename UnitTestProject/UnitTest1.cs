using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass] // this attribute indicates the compiler that here is a class that behaves as a Test
    [TestCategory("Part3")] // using this attribute we can group the tests by traits
    public class UnitTest1
    {
        private int a;
        public TestContext test3context { get; set; }  // public property
        private static TestContext _testContext;  // private variable that is only available to the class
        [TestInitialize]
        public void RunbeforeEveryTest()
        {
            a = 1;
        }
        [TestCleanup]
        public void RunAfterEveryTestMethod()
        {
            Trace.Write("RunAfterEveryTestMethod will execute after every single test method in the class");

        }
        [ClassInitialize]
        public static void RunBeforeAllTestMethodStarted(TestContext testContext) // the method has to be static

             //this has to be syntax for classinitialize(only name of the method can change)
        {
            _testContext = testContext;
            Trace.Write("I will run one time before all the tests in the class started");
        }

        [ClassCleanup]
        public static void RunAfterAllTestMethodCompleted()
        {
            Trace.Write("I will run one time after all the tests in the class started");
        }


        [TestMethod]
        
        [Description("this is a positive flow")] // description attribute is only valid for test methods not test classes
        public void TestMethod1() // this attribute indicates the compiler that here is a method that behaves as a Test
        {
           
            var b = 2;

            Assert.AreEqual(3, a + b);

            Trace.Write(_testContext.CurrentTestOutcome);
        }

        [TestMethod]
        public void TestMethod2() // this attribute indicates the compiler that here is a method that behaves as a Test
        {
            Trace.Write(_testContext.TestName);
            Assert.IsTrue(a == 1);
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestMethod3() // this attribute indicates the compiler that here is a method that behaves as a Test
        {
            var a = 1;

            Assert.AreNotEqual(1, a);

        }
    }
}
