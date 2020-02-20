using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void addnum(int x, int y);
public delegate void subnum(int x, int y);

namespace AdvancedCSharpTopics
{
    public class Delegate_Demo2
    {
        public  void sum(int a,int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        public void subtract(int a,int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);

        }

        public static void Main()
        {
            Delegate_Demo2 del2 = new Delegate_Demo2();
            addnum del_obj1 = new addnum(del2.sum);
            subnum del_obj2 = new subnum(del2.subtract);

            del_obj1(100, 40);
            del_obj2(100, 60);

        }
    }
}
