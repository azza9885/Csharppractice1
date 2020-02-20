using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace ArraysandLists
{
    [TestClass]
    public class List_Cleaner
    {
        [TestMethod]
        public void ListCleanerApp()
        {
            ArrayList dataList = new ArrayList();

            dataList.Add("Someday");

            dataList.Add(2);

            dataList.Add("app");

            dataList.Add("13.5");

            dataList.Add("red");

            dataList.Add(8);

            dataList.Add(99);

            dataList.Add("6");

            dataList.Add("Meatball soup");

            dataList.Add(18M);

            dataList.Add("pieces");

            dataList.Add("14");

            ArrayList goodValue = CheckList(dataList);
            int sum = SumofGoodValue(goodValue);
            Assert.AreEqual(147, sum);

        }

        public ArrayList CheckList(ArrayList datalist)
        {

            ArrayList Goodvalues = new ArrayList();
            foreach(var item in datalist)
            {
                int aValue;
                if(int.TryParse(Convert.ToString(item),out aValue) == true)
                {
                    Goodvalues.Add(aValue);
                }
            }
            return Goodvalues;
        }

        public int SumofGoodValue(ArrayList datalist)
        {
            int sum = 0;
            foreach(int item in datalist)
            {
                sum += item;
            }

            return sum;
        }
    }
}
