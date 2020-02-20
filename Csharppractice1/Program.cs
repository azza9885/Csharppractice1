using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharppractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string itemName = "widget";
            //double productPrice = 17.6;

            ////string statement = String.Format("The price of the product is {0:C}",productPrice);

            //string statement = String.Format("{0,10}{1:C,10}" , itemName, productPrice);
            //Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));
            //Console.WriteLine(statement);

            string file1 = "C:\\Project\\Folder\\files";

            string file2 = @"C:\Project\Folder\files"; // example of verbatim strings

            //string file3 = "C:\Project\Folder\files" // this will automatically display an error

            Console.WriteLine(file1);
            Console.WriteLine(file2);
           

            Console.ReadLine();

        }
    }
}
