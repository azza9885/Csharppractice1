using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics
{
    abstract class Person // wont be able to create a object of this class, will only be allowed to create objects of the derived class from this base class
    {
        private string idNumber;
        private string firstName;
        private string lastName;
        private int age;
        protected DateTime dateOfBirth; //example for protected access modifier , this will be avaiable to be accessed 
                                        // in an inherited class , for example it can be accessed from student class but not
                                       // from the inheritance_test class
        public Person()
        {

        }

        public Person(string id,string fname,string lname,int anAge,DateTime dob)
        {
            idNumber = id;
            firstName = fname;
            lastName = lname;
            age = anAge;
            dateOfBirth = dob;
        }

        public abstract string GetExerciseHabits(); // body should not be defined for abstract methods and creation of an abstract methods compels the derived classes to implement these abstract methods otherwise
                                                    // the compiler is going to throw an error
    }
}
