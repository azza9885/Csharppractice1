using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4testingSentinelLoops
{
    class SentinelLoops
    {
        static void Main()
        {

            string str = "";
            while (str != "-99")
            {
                Console.WriteLine(" Enter -99 to end the loop");
                str = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
