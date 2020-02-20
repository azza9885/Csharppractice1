using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathwithDecimal
{
    [TestClass]
    public class MathwithDecimal
    {
        static decimal number1;
        static decimal number2;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            number1 = 10.5M; //M is required to be added for a decimal to
            number2 = 5.0M;// indicate the compiler that this is a decimal 
                          // number, else it throws an error
        }
        [TestMethod]
        public void Test_Addition()
        {
            decimal Addition = number1 + number2;
            Assert.AreEqual(Addition, 15.5M);
        }

        [TestMethod]
        public void Test_Subraction()
        {
            decimal Subraction = number1 - number2;
            Assert.AreEqual(Subraction, 5.5M);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            decimal Multiplication = number1 * number2;
            Assert.AreEqual(Multiplication, 52.5M);
        }

        [TestMethod]
        public void Division()
        {
            decimal division = number1 / number2;
            Assert.AreEqual(division, 2.1M);
        }

        [TestMethod]
        public void Modulus()
        {
            decimal Modulus = number1 % number2;
            Assert.AreEqual(Modulus, 0.5M);
        }
    }
}
