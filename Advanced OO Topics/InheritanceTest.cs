using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Advanced_OO_Topics
{
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void InheritanceTestMethod_1()
        {
            DateTime dob = new DateTime(1985, 08, 09);
           // Person _newPerson = new Person("11111", "Rohit", "Sharma", 32); // wont be able to create a object of this class, will only be allowed to create objects of the derived class from this base class
            Student _newStudent = new Student("2222", "Virat", "Kohli",34,dob,"M0982","Electrical Engineering");

            string exercisehabits_Response = _newStudent.GetExerciseHabits();
            Console.WriteLine(exercisehabits_Response);

        }

        [TestMethod]
        public void Composition_Test()
        {
            //datatime object has to be instantiated before it can be used //compoisition
            DateTime dob = new DateTime(1985, 08, 09);
            Student _newStudent = new Student("2222", "Virat", "Kohli",34, dob, "M0982", "Electrical Engineering");
        }

        [TestMethod]
        public void PrintProtectedDOB()
        {
            DateTime dob = new DateTime(1985, 08, 09);
            Student _newStudent = new Student("2222", "Virat", "Kohli", 34, dob, "M0982", "Electrical Engineering");
            Console.WriteLine(_newStudent.dob());
        }

       [TestMethod]
       public void PolyMorphism_Example()
        {
            ArrayList PersonList = new ArrayList();
            DateTime dob = new DateTime(1985, 04, 21);
            Person_Poly myPerson = new Person_Poly("12343", "Tom", "Latham",26, dob);
            DateTime dob1 = new DateTime(1975, 04, 21);
            Student_Poly myStudent = new Student_Poly("6262288", "Russel", "Crowe",45, dob1,"SD62627","Data Science");
            PersonList.Add(myPerson);
            PersonList.Add(myStudent);

            foreach(Person_Poly item in PersonList)
            {
                Console.WriteLine(item.HoursOfSleep());
            }

        }

        [TestMethod]
        public void SealedClassExample_Test()
        {
            SealedClass_Examples Pen = new SealedClass_Examples("Ball-Point Pen");
            Console.WriteLine($"The Pen Type is : {Pen.return_PenType()}");
        }
    }
}
