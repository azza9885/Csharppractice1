using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesNmethods
{
    [TestClass]
    public class EmployeeClass1Test
    {
        [TestMethod]
        public void Employee_LocationTest()
        {
            EmployeeClass1 employee1 = new EmployeeClass1(123);

            employee1.Jobtitle = "Manager";

            string empLoc = employee1.JobLocation();
            Assert.AreEqual(empLoc, "Boston");
            Console.WriteLine("the employee location is : " + empLoc);


        }

        [TestMethod]
        public void ToString_Test()
        {
            EmployeeClass1 eToTest = new EmployeeClass1("Steve Waugh", 554, "Manager");

            Console.WriteLine(eToTest);
        }
    }
}
