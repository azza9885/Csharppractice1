using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    class Person_Poly
    {

        private string idNumber;
        private string firstName;
        private string lastName;
        private int age;
        protected DateTime dateOfBirth; //example for protected access modifier , this will be avaiable to be accessed 
                                        // in an inherited class , for example it can be accessed from student class but not
                                        // from the inheritance_test class
        public Person_Poly()
        {

        }

        public Person_Poly(string id, string fname, string lname, int anAge, DateTime dob)
        {
            idNumber = id;
            firstName = fname;
            lastName = lname;
            age = anAge;
            dateOfBirth = dob;
        }

       // public abstract string GetExerciseHabits(); cannot use abstract method since this is not an abstract class

        public virtual string HoursOfSleep()
        {
            return "A person gets 8 hours of Sleep";
        }

    }
}
