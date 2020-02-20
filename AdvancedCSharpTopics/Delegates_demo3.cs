using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void rectangle(double height, double width);

namespace AdvancedCSharpTopics
{
    public class Delegates_demo3
    {
        public void rectangle_area(double a,double b)
        {
            Console.WriteLine("The area of the rectangle is : {0}", a * b);
        }

        public void rectangle_perimeter (double a ,double b)
        {
            Console.WriteLine("The perimeter of the rectange is :{0}", 2 * (a + b));
        }

        public static void Main()
        {
            Delegates_demo3 obj = new Delegates_demo3();
            rectangle del3 = null;
            del3 += new rectangle(obj.rectangle_area);
            del3 += new rectangle(obj.rectangle_perimeter);

            del3(4, 4);
            Console.WriteLine();

            del3(5, 4);

        }
    }
}
