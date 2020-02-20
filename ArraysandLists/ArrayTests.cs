using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraysandLists
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void ArrayExample()
        {
            int[] Array1 = new int[14];
            Array1[0] = 24;
            Array1[1] = 32;

            String Statement = String.Format("Price1 is {0:C}" + "\n Price2 is {1:C}", Array1[0], Array1[1]);
            Console.WriteLine(Statement);

            int value = 6;
            int[] Array2 = new int[value];
            //int Array2_Length = Array2.Lengt };
            //Console.WriteLine("Array 2 length is : ", Array2_Length);

        }
        [TestMethod]
        public void ForEachLoop_Test()
        {
            int[] scores = { 2, 4, 6, 8, 19 };
             foreach(int value in scores)
            {
                Console.WriteLine($"\n value in the scores arrays is {value}");
            }
        }

        public int PassArraytoMethod_Example(int[] _scores)
        {
            int sum = 0;
            foreach(int score in _scores)
            {
                sum += score;
            }
            return sum;
        }

        [TestMethod]
        public void PassArraytoMethod_ExampleTest()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            int ArraySum = PassArraytoMethod_Example(scores);
            Console.WriteLine($"Sum of all Array elements is : {ArraySum} ");
            Assert.AreEqual(30, ArraySum);
        }

        public string CheckScore(int _score)   //PassArrayElEMENTtoMethod_Example
        {
            if(_score >= 10)
            {
                return "Pass";
            }

            else
            {
                return "Fail";
            }
        }
        [TestMethod]
        public void PassArrayElEMENTtoMethod_ExampleTest()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            foreach(int score in scores)
            {
                Console.WriteLine($"The value of score is {score} and the result returned from Checkscore method is : " + CheckScore(score));
            }
        }

        [TestMethod]
        public void ArrayClass_Test()
        {
            double[] _waterDepth = { 18.9, 7.9, 35.3 };
            Array.Sort(_waterDepth);
            foreach(double value in _waterDepth)
            {
                Console.Write("\t" + value);
            }

            Array.Reverse(_waterDepth);
            foreach(double value in _waterDepth)
            {
                Console.Write("\t" + value);
            }
            
        }
    }
}
