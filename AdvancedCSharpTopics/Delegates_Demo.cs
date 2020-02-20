using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void Procedure();

namespace AdvancedCSharpTopics
{
    public class Delegates_Demo
    {
        public static void Method1()
        {
            Console.WriteLine("Method1");

        }

        public static void Method2()
        {
            Console.WriteLine("Method2");

        }

        public void Method3()
        {
            Console.WriteLine("Method3");

        }

        public static void Main()
        {
            Procedure someprocs = null;

            someprocs += new Procedure(Delegates_Demo.Method1);
            someprocs += new Procedure(Delegates_Demo.Method2);
            
            Delegates_Demo del = new Delegates_Demo();
            someprocs += new Procedure(del.Method3);
            someprocs();


        }
    }
}
