using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesNmethods
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Car_Color_Set()
        {
            //arrange
            Car myCar = new Car("Red", 2, true);

            //act

            //assert
            StringAssert.Equals(myCar.Color, "Red");
        }

        [TestMethod]
        public void Call_Accelerate_Method()
        {
            Car myCar = new Car("Blue", 4, true);

            myCar.Accelerate();
        }
        [TestMethod]
        public void Call_FamilyCar_Method()
        {
            Car myCar = new Car("Dark Red", 4,true);

            bool isthisafamilyCar = myCar.FamilyCar();

            if(isthisafamilyCar==true)
            {
                Assert.IsTrue(isthisafamilyCar);
                Console.WriteLine("Yes this is a Family Car");

            }

            else
            {
                Assert.Fail();
            }
        }
    }
}
