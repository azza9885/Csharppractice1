using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpTopics
{
    public static class Lambda_example1
    {
        public static void Main()
        {
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach(var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
