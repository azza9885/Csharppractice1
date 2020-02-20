using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathwithIntergers
{
    [TestClass]
    public class MathwithIntegers
    {
        static int number1;
        static int number2;
        private static TestContext _testContext;

        [ClassInitialize]
        public static void integerinitialize(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
            _testContext = testContext;
        }
        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine("Sum of number1 and number2 is :" + sum);
            Assert.AreEqual(sum, 15);
        }
        [TestMethod]
        public void Test_Subraction()
        {
            int difference = number1 - number2;
            Assert.AreEqual(difference, 5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int multiplication = number1 * number2;
            Assert.AreEqual(multiplication, 50);
        }

        [TestMethod]
        public void Test_Division()
        {
            int division = number1 / number2;
            Assert.AreEqual(division, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int modulus = number1 % number2;
            Assert.AreEqual(modulus, 0);
        }
    }
}
