using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class MathFunctions_Test
    {
        [TestMethod]
        public void SquareRoot_Test()
        {
            double _sRoot = MathFunctions.SquareRoot(81);
            Assert.AreEqual(_sRoot, 9);
        }

        [TestMethod]
        public void Sum_int()
        {
            int sumValue = MathFunctions.Sum(2, 3);
            Assert.AreEqual(sumValue, 5);
        }

        [TestMethod]
        public void Sum_double()
        {
            double sumVal = MathFunctions.Sum(7.3, 31.8);
            Assert.AreEqual(sumVal, 39.1);
        }

        [TestMethod]
        public void Sum_decimal()
        {
            decimal sumV = MathFunctions.Sum(9999.9M, 1.1M);
            Assert.AreEqual(sumV, 10001M);
        }
    }
}
