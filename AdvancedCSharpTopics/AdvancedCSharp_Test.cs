using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace AdvancedCSharpTopics
{
    [TestClass]
    public class AdvancedCSharp_Test
    {
        [TestMethod]
        public void ImplicitCasting_test()
        {

            Mammal Mammal1 = new Cat();
            Animal Animal1 = new Cat(); // Since Cat inherits from Mammal which inherits from Animal, 3 levels pf hierarchy , any child can masquerade as a base class 
            Animal Animal2 = new Mammal(); // since Mammmal inherits from Animal
            //Cat Cat1 = new Animal(); doesnt work
            //Cat Cat2 = new Mammal(); doesnt work
        }

        [TestMethod]
        public void ExplicitCasting_test()
        {
            double dPi = 3.145926535;

            int iValue = (int)dPi;
            Console.WriteLine(iValue); // displays 3 and looses the precision since integers are whole numbers only, parsing strings received by the user is also a good example
                                       // sometimes conversion might not be succesful , that has to be kept in mind when doing explicit casting

        }

        [TestMethod]
        public void BoxingCasting_Example()  // process of converting a value type to an object type , expensive since object needs to created and casted
        {
            double dPi = 3.145926535;
            object oPi = (object)dPi;

            Console.WriteLine(oPi);
        }

        [TestMethod]
        public void UnboxingCasting_Example() // Process of converting an object type to a value type is unBoxing
        {
            double dPi = 3.145926535;
            object oPi = (object)dPi;

            dPi = (double)oPi;
            Console.WriteLine(dPi);
        }

        [TestMethod]
        public void Delegates_DemoTest()
        {
            Delegates_Demo.Main();
        }

        [TestMethod]
        public void Delegates2_DemoTest()
        {
            Delegate_Demo2.Main();
        }

        [TestMethod]
        public void Delegates3_DemoTest()
        {
            Delegates_demo3.Main();
        }

        [TestMethod]
        public void LambdaExample1_Test()
        {
            Lambda_example1.Main();
        }

        [TestMethod]
        public void Lambda_Example2_Test()
        {
            Lambda_Example2.Main();
        }

        [TestMethod]
        public void Lambda_Example_Dog_test()
        {
            DogName_Demo.Main();
        }

        [TestMethod]
        public void LambdaExample_BabyNameTest()
        {
            demo1.Main();
        }


        delegate int del(int i);
        [TestMethod]
        public void LamdbaExample_BabyName_AgeSortTest()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5);
            Assert.AreEqual(j, 25);
        }

        [TestMethod]
        public void TestList_Lambda()
        {
            List<int> list_of_Numbers = new List<int>() { 10, 20, 30, 41, 60, 71, 97, 98, 65 };
            int first_oddNumber_index = list_of_Numbers.FindIndex(x => x % 2 != 0);
            int last_oddNumber_index = list_of_Numbers.FindLastIndex(x => x % 2 != 0);
           
            Console.WriteLine("First odd number index in the list of number is :  " + first_oddNumber_index);
            Console.WriteLine("Last odd number index in the list of number is :  " + last_oddNumber_index);
        }

        delegate void TestDelegate(string s);
        [TestMethod]
        public void StatementLambda_Test()
        {
            TestDelegate del = n => { 
                                     string s = n + " World";                
                                     Console.WriteLine(s); 
                                    };
            del("Hello");
        }

        [TestMethod]
        public void RegexTest1()
        {
            RegularExpressions_Example1.Main();
        }
    }
}
