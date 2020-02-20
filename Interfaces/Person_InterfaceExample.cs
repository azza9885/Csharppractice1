using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Person_InterfaceExample 
    {
        private string idNumber;
        private string firstName;
        private string lastName;
        private int age;
        protected DateTime dateOfBirth; //example for protected access modifier , this will be avaiable to be accessed 
                                        // in an inherited class , for example it can be accessed from student class but not
                                        // from the inheritance_test class
        public Person_InterfaceExample()
        {

        }

        public Person_InterfaceExample(string id, string fname, string lname, int anAge, DateTime dob)
        {
            idNumber = id;
            firstName = fname;
            lastName = lname;
            age = anAge;
            dateOfBirth = dob;
        }

        public override string ToString()
        {
            return "\n Person ID : " + idNumber + " " + " First Name : " + firstName + " " + " Last Name: " + lastName + " " + " \n Age: " + age + " " + "\n DOB : " + dateOfBirth;
        }
    }
}
