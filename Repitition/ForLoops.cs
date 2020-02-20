using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void NestedLoops_Test()
        {
            int outerLoop_control = 0;
            int innerloop_control = 10;

            while (outerLoop_control < 3)
            {
                innerloop_control = 10;

                while (innerloop_control > 5)
                {
                    Console.WriteLine(" \n Outer : " + outerLoop_control + " \t \t Inner: " + innerloop_control);
                    innerloop_control--;

                }

                outerLoop_control++;

            }
        }

        [TestMethod]
        public void ForLoopsExample() // repeating the above while loop example in for loops
        {
            for(int outer=0;outer < 3; outer++)
            {
                for(int inner = 10; inner > 5; inner--)
                {
                    Console.WriteLine($"Outer : {outer} \t \t Inner: {inner}");
                    //Console.WriteLine(" \n Outer : " + outer + " \t \t Inner: " + inner);
                }
            }
        }


    }
}
