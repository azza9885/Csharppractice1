using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interfaces
{
    [TestClass]
    public class InterfaceExample_Test
    {
        [TestMethod]
        public void PersonInterface_Test()
        {
            DateTime dob1 = new DateTime(1976, 06, 19);
            DateTime dob2 = new DateTime(1970, 04, 15);
            DateTime dob3 = new DateTime(1995, 03, 25);
            DateTime dob4 = new DateTime(1998, 01, 21);
            Professor_InterfaceExample prof1 = new Professor_InterfaceExample("23AB28", "Arvind", "Kejriwal", 44, dob1, "E345", "Applied Physics");
            Professor_InterfaceExample prof2 = new Professor_InterfaceExample("43FGB28", "Manish", "Pandey", 50, dob2, "E345", "Data Science");
            Student_InterfaceExample student1 = new Student_InterfaceExample("R01022", "Tiger", "Shroff", 23, dob3, "S234", "MSEE");
            Student_InterfaceExample student2 = new Student_InterfaceExample("M9292929", "Zaheer", "Khan", 21, dob4, "S235", "MSCS");

            Person_InterfaceExample[] listof_People = new Person_InterfaceExample[4];
            listof_People[0] = prof1;
            listof_People[1] = prof2;
            listof_People[2] = student1;
            listof_People[3] = student2;

            foreach(Person_InterfaceExample someone in listof_People)
            {
                Console.WriteLine(someone);
            }
        }
    }
}
