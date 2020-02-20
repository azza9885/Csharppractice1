using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesNmethods
{
    [TestClass]
    public class TripClassTest
    {
        [TestMethod]
        public void TripClass_MilespeG_Test()
        {
            TripClass MPGtest = new TripClass("NYC", 325, 39, 13);
            double MPG = MPGtest.Calculate_Miles_perGallon();
            Console.WriteLine("the miles per gallon for trip to " + MPGtest.Destination + " is " + MPG);
            Assert.AreEqual(MPG, 25);
        }

        [TestMethod]
        public void TripClass_CPM_Test()
        {
            TripClass CPMTest = new TripClass("NYC", 325, 39, 13);
            double CPM = CPMTest.Cost_per_Mile();
            string CPM_currency = String.Format("{0:C}", CPM);
            Console.WriteLine("The cost per mile for trip to : " + CPMTest.Destination + " is " + CPM_currency);
        }

        [TestMethod]
        public void TripClass_ToStringTest()
        {
            TripClass ToStringPrint = new TripClass("NYC", 325, 39, 13);
            Console.WriteLine(ToStringPrint);
        }
    }
}
