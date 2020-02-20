using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Methods
{
    [TestClass]
    public class Method_Test
    {
        [TestMethod]
        public void Test_Square()
        {
            Method_Test m_Test = new Method_Test();
            int square_result = m_Test.square(6);
            Assert.AreEqual(square_result, 36);

        }

        public int square(int number)
        {
            return number * number;
        }

        [TestMethod]
        public void Test_square_static()  // this uses a static Math Helper method and it does not require to be instantiated like the regular method.
        {
            int square_result = MathHelper.square(6);
            Assert.AreEqual(square_result, 36);
        }

        [TestMethod]
        public void Test_square_namedParameter()
        {
            Assert.AreEqual(36, MathHelper.square_namedParameter(aValue: 6));
        }

        [TestMethod]
        public void Test_Addition_OptionalParameter()
        {
            Assert.AreEqual(35, MathHelper.Addition_Mathhelp(number_1:25));
        }

        [TestMethod]
        public void OutKeywordTest()
        {
            int number1;
            MathHelper.OutKeyword(out number1);
            Assert.AreEqual(10, number1);
        }

        [TestMethod]
        public void RefKeywordTest()
        {
            int number1=0;   // this is the difference between out and ref keyword usage, the variable using to call the method using ref keyword needs to be initialized which
                           // which is not required with out keyword
            MathHelper.RefKeyword(ref number1);
            Assert.AreEqual(20, number1);
        }

        [TestMethod]
        public void EmployeePayTypeTest_usingTitle()
        {
            EmployeeClass1 eC1 = new EmployeeClass1("Rohit Sharma",12345,"Manager");
            string payType = eC1.PayType(eC1.Jobtitle);
            Console.WriteLine(payType);

        }
        [TestMethod]
        public void EmployeePayTypeTest_usingID()
        {
            EmployeeClass1 eC1 = new EmployeeClass1("Nick Foles", 54321, "Staff");
            string payType = eC1.PayType(eC1.Id);
            Console.WriteLine(payType);
        }

        [TestMethod]
        public void Tuples_Test()
        {
            //create the Tuple
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "Cat", true);

            //Access the Tuple
            if (myTuple.Item1==1)
            {
                Console.WriteLine(myTuple.Item1);
            }

            if(myTuple.Item2 =="Dog")
            {
                Console.WriteLine(myTuple.Item2);
            }

            if (myTuple.Item3)
            {
                Console.WriteLine(myTuple.Item3);
            }
        }
    }
}
