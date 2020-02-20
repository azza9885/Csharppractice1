using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearFinder
{
    [TestClass]
    public class LeapYearFinder
    {
   
        [TestMethod]
        public void checkforyear2018()
        {
            bool result = PassifthisisaLeapYear(1900);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void checkforyear2020()
        {
            bool result = PassifthisisaLeapYear(2020);
            Assert.IsTrue(result);
        }
        private bool PassifthisisaLeapYear(int givenYear)
        {
            bool YesLeapYear;
            int LeapYearint = givenYear;
            string LeapYearString = LeapYearint.ToString();
            if (LeapYearint % 2 == 0)
            {
                if(LeapYearint % 100 == 0)
                {
                    if(LeapYearint % 400 == 0)
                    {
                       if(LeapYearint % 4 == 0)
                        {
                            Console.WriteLine($"Yayy!!!..you are right.....{LeapYearint} is a Leap Year ... and it was divisible by 4,100 and 400..");
                            YesLeapYear = true;
                        }

                        else
                        {
                            Console.WriteLine($"{LeapYearString} is not a leap year,it was divisible by 100,400 ,but was not divisible by 4.Try your guess by entering another year..");
                            YesLeapYear = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine($"{LeapYearString} is not a leap year, try your guess by entering another year..");
                        YesLeapYear = false;
                    }
                }

                else if(LeapYearint % 400 == 0)
                {
                   
                        if (LeapYearint % 4 == 0)
                        {
                            Console.WriteLine($"Yayy!!!..you are right.....{LeapYearint} is a Leap Year ... and it was divisible by 4 and 400..");
                            YesLeapYear = true;
                        }

                        else
                        {
                            Console.WriteLine($"{LeapYearString} is not a leap year,it was divisible by 400 ,but was not divisible by 4 and 100.Try your guess by entering another year..");
                            YesLeapYear = false;
                        }
                 

                }

                else if(LeapYearint % 4 == 0)
                {
                    Console.WriteLine($"Yayy!!!..you are right.....{LeapYearint} is a Leap Year ... and it was divisible by 4 but was not divisible by 100 and 400..");
                    YesLeapYear = true;
                }

                else
                {
                    Console.WriteLine($"{LeapYearString} is not a leap year,it was an even number year but not divisible by 4,100 and 400 ,Try your guess by entering another year..");
                    YesLeapYear = false;
                }
            }

            else
            {
                Console.WriteLine($"{LeapYearString} is not a leap year, this is a odd number year...try your guess by entering another even number year..");
                YesLeapYear = false;
            }

        return YesLeapYear;
        }
    }
}
