using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConversion
{
    [TestClass]
    public class TemperatureConversion
    {
        static float TempinC;
        static double TempinF;
        //static float ConvTempCtoF;
        //static float ConvTempFtoC;
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            //TempinC = 33;
            //TempinF = 20;
        }
        [TestMethod]
        public void Convert_F_To_C()
        {
            //given the temperature in fahrenheit use a math expression 
            //to convert the temp 
            //to celsius.display a output string to the console,
            //that says" the Temp in F  (given temp) is (temp) in C
            //replacing the values as neccessary in the string
            double TempinF = 57;
            double ConvTempFtoC = (TempinF - 32)* .5556;
            Console.WriteLine($"The Temp in Fahrenheit is {TempinF} is {ConvTempFtoC} in Centigrade");
            Assert.AreEqual(ConvTempFtoC, 13.89,0.001);

        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            //given the temperature in Celsius use a math expression 
            //to convert the temp 
            //to fahrenheit.display a output string to the console,
            //that says" the Temp in C  (given temp) is (temp) in F
            //replacing the values as neccessary in the string
            double TempinC = 33;
            double ConvTempCtoF = (TempinC * 1.8) + 32;
            Assert.AreEqual(ConvTempCtoF, 91.4);
            
            Console.WriteLine("The Temp in Centigrade is {0} is {1} in Fahrenheit",TempinC,ConvTempCtoF);
        }
    }
}
