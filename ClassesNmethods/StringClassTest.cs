using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesNmethods
{
    [TestClass]
    public class StringClassTest
    {
        [TestMethod]
        public void StringClass_Test()
        {
            string str = "Who Am I ....I am Spiderman!!!";
            Console.WriteLine(str);
            string substr = str.Substring(13);
            Console.WriteLine(substr);

        }

        public void stitch_strings_together()
        {
            char[] chars = { 'H', 'E', 'L', 'L', 'O' };
            string name = new string(chars);
            Console.WriteLine(name);
        }
    }
}
