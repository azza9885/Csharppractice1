using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathwithDouble
{
    [TestClass]
    public class MathWithDouble
    {
        static double number1 ;
        static double number2 ;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            number1 = 10.5;
            number2 = 5.0;
        }
        [TestMethod]
        public void Test_Addition()
        {
            double Addition = number1 + number2;
            Assert.AreEqual(Addition, 15.5);
        }

        [TestMethod]
        public void Test_Subraction()
        {
            double Subraction = number1 - number2;
            Assert.AreEqual(Subraction, 5.5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            double Multiplication = number1 * number2;
            Assert.AreEqual(Multiplication, 52.5);
        }

        [TestMethod]
        public void Division()
        {
            double division = number1 / number2;
            Assert.AreEqual(division, 2.1);
        }

        [TestMethod]
        public void Modulus()
        {
            double Modulus = number1 % number2;
            Assert.AreEqual(Modulus, 0.5);
        }
    }

}
