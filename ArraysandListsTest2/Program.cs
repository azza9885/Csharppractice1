using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysandListsTest2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] entries = new int[11];
            int countof_InvalidEntries = 0;
            int numbersOutofRange = 0;

            PrimeArray(entries);
            countof_InvalidEntries =  GetValues(entries, ref numbersOutofRange);
            DisplayResults(entries, countof_InvalidEntries, numbersOutofRange);
            Console.ReadKey();
        }

        public static void PrimeArray(int[] entries)
        {
            for(int i = 0; i < 11; i++)
            {
                entries[i] = 0;
            }
        }


        public static int GetValues(int[] entries,ref int numbersOutofRange)
        {
            int inValue = 0;
            bool moreInput = true;
            string userInput;
            int countof_InvalidEntries = 0;
            Console.Clear();

            while (moreInput)
            {
                Console.WriteLine("Please Enter a value between 0 and 10 (enter -1 to exit)");

                userInput = Console.ReadLine();
                while (Int32.TryParse(userInput, out inValue) == false)  // using while here since even if the condition is false, the value will be assigned to inValue from that point in the code
                {
                    Console.WriteLine("Invalid Input type" + " Please Enter a value between 0 and 10 (enter -1 to exit) ");
                    userInput = Console.ReadLine();
                    countof_InvalidEntries++;
                }

                if(inValue == -1)
                {
                    moreInput = false;
                }

                else if (inValue < 0 || inValue > 10)
                {
                    Console.WriteLine("Number is out of Range " + " Please Enter a value between 0 and 10 (enter -1 to exit) ");
                }

                else
                {
                    entries[inValue]++;
                }
            }
            return countof_InvalidEntries;
        }

        public static void DisplayResults(int[] entries,int countof_InvalidEntries, int numbersOutofRange)
        {
            int CountofValidEntries = 0;
            Console.Clear();
            Console.WriteLine("\t InputData App");
            Console.WriteLine("{0,-12}{1,-6}", "InputValue", "Count");

            for (int x = 0; x <= 10; x++)
            {
                if(entries[x] != 0)
                {
                    CountofValidEntries += entries[x];
                    Console.WriteLine("{0,5}{1,10}", x, entries[x]);

                }
            }

            Console.WriteLine("Number of Non-Numeric Entries : {0}", countof_InvalidEntries);
            Console.WriteLine("Number of values entered out of range : {0}", numbersOutofRange);
            Console.WriteLine("Number of Valid entries : {0}", CountofValidEntries);
            Console.WriteLine("Total number of entries :{0}", CountofValidEntries + countof_InvalidEntries + numbersOutofRange);

        }
    }
}
