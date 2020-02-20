using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpTopics
{
    public static class Lambda_Example2
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> oddnumbers = list.FindAll(x => (x % 2) == 1);
            int firstevennumber = list.FirstOrDefault(y => (y % 2) == 0);
            int lastevennumber = list.FindLast(x => (x % 2) == 0);
            int lastoddnumber = list.FindLast(x => x % 2 == 1);

            foreach(var num in oddnumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"First evennumber is :  {firstevennumber}");

            Console.WriteLine($"Last evennumber is :  {lastevennumber}");

            Console.WriteLine($"Last oddnumber is :  {lastoddnumber}");
        }
        

    }
}
