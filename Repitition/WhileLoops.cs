using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void WhileLoops_Test() // counter control loops example , where a finite counter value is known for loop repitition
        {
            //code will continue to execute while the conditional statement is true
            int i = 1;
            while (i < 11)
            {
                //Console.WriteLine("Value of i is :" + i);
                Console.WriteLine($"Value of i is {i}");
                i++;
            }
        }

        [TestMethod]
        public void SentinelLoops_Test()
            //Sentinel loops - where the number of iterations for the loop is not known during coding and depends
            // on a conditional statement or is given as an input from another file.
        {
            string str = "";
            while (str != "-99")
            {
                Console.WriteLine(" Enter -99 to end the loop");
                str = Console.ReadLine();
            }
            Console.ReadKey();
        }
             

        [TestMethod]
        public void Test_Operators()
        {
            int number = 1;
            Console.WriteLine("The value of number is {0}", number++);
            Console.WriteLine("The value of number is {0}", ++number);
            Console.WriteLine("The value of number is {0}", number--);
            Console.WriteLine("The value of number is {0}", --number);
        }


        [TestMethod]
        public void Nested_Loops()
        {
            int number1 = 1;
            int number2 = 1;

            while (number1 <= 5)
            {
                while(number2 <= number1)
                {
                    Console.WriteLine(number2);
                    number2++;
                }
                number1++;
            }
        }

        [TestMethod]
        public void NestedLoops_Test()
        {
            int outerLoop_control = 0;
            int innerloop_control = 10;

            while(outerLoop_control < 3)
            {
                innerloop_control = 10;

                while (innerloop_control > 5)
                {
                    Console.WriteLine(" \n Outer : " + outerLoop_control + " \t \t Inner: " + innerloop_control);
                    innerloop_control--;
                   
                }

                    outerLoop_control++;
 
            }
        }
    }
}
