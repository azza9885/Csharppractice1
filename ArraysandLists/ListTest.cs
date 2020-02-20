using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections; //required for using ArrayLists

namespace ArraysandLists
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void Test1_ArrayList()
        {
            ArrayList myList = new ArrayList();
            myList.Add(20);
            myList.Add(40);
            myList.Add(56);
            myList.Add(45);
            Console.WriteLine(myList.Count);
            myList.RemoveAt(3);
            Console.WriteLine(myList.Count);
        }

        [TestMethod]
        public void SumofScores()
        {
            ArrayList scores = new ArrayList();
            FillingList(scores);
            int sum = TotalSumofScores(scores);
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void ArrayList_Example()
        {
            ArrayList myList = new ArrayList();
            myList.Add(20);
            myList.Add(45);
            myList.Add(44);
            myList.Add(99);
            myList.Add(101);
            myList.Add(77);
            myList.Add(54);

            Console.WriteLine("Array List Capacity is : {0}", myList.Capacity);
            Console.WriteLine($"Array List Count is : {myList.Count}");

            foreach (int i in myList)
            {
                Console.Write(i + " ");
            }

            myList.Sort();
            Console.WriteLine();
            foreach (int i in myList)
            {
                Console.Write(i + " ");
            }


        }

        public void FillingList(ArrayList Scores)
        {
            for (int i = 0; i <= 20; i++)
            {
                Scores.Add(i);
            }
        }

        public int TotalSumofScores(ArrayList Scores)
        {
            int sum = 0;
            foreach(int score in Scores)
            {
                sum += score;
            }

            return sum;
        }


    }
}
