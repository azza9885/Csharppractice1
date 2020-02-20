using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Methods_finaltest_UnitTest
    {
        [TestMethod]
        public void Test_CurrentYear_assesed_Value()
        {
            Methods_FinalTest MethodsFinalTestObject = new Methods_FinalTest("1234 King of Prussia Rd,King of Prussia,PA 19406", 1000000M);
            decimal CurrentYearValue_Home = MethodsFinalTestObject.CurrentYearHomeValue();
            Assert.AreEqual(CurrentYearValue_Home, 1027000M);
        }
        [TestMethod]
        public void Test_MillageRate()
        {
            Assert.AreEqual(1.003M, Methods_FinalTest.MillageRate());
        }

        [TestMethod]
        public void TaxableValue_Home()
        {
            Methods_FinalTest MethodsFinalTestObject = new Methods_FinalTest("1234 King of Prussia Rd,King of Prussia,PA 19406", 1000000M);
            decimal TaxableHomeValue = MethodsFinalTestObject.Taxable_Value();
            Assert.AreEqual(1002000, TaxableHomeValue);
        }

        [TestMethod]
        public void HomeOwnerDetails()
        {
            Methods_FinalTest MethodsFinalTestObject1 = new Methods_FinalTest("1234 King of Prussia Rd,King of Prussia,PA 19406", 1000000M);
            Methods_FinalTest MethodsFinalTestObject2 = new Methods_FinalTest("1234 Great Valley Parkway,Malvern,PA 19355", 500000M);
            Methods_FinalTest MethodsFinalTestObject3 = new Methods_FinalTest("4321 SugarTown Road,Devon,PA 19355", 400000M);

            Console.WriteLine("\n" + MethodsFinalTestObject1);
            Console.WriteLine("\n" + MethodsFinalTestObject2);
            Console.WriteLine("\n" + MethodsFinalTestObject3);
        }
    }
}
