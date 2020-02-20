using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advanced_OO_Topics
{
    [TestClass]
    public class CodingQuiz_UnitTest
    {
        [TestMethod]
        public void TestMethod_Play()
        {
            CodingQuiz_Play playInfo = new CodingQuiz_Play("12345", 4500, "BAN345", "3", "Game of Thrones", "Barry John Group of Actors");
            Console.WriteLine(playInfo.GetEvent_Details());
        }

        [TestMethod]
        public void TestMethod_Lecture()
        {
            CodingQuiz_Lecture _lectureInfo = new CodingQuiz_Lecture("72727", 200, "3ID345", "2", "Personality Development ", "R.Madhavan");
            Console.WriteLine(_lectureInfo.GetEvent_Details());
        }

        [TestMethod]
        public void TestMethod_Musical()
        {
            CodingQuiz_Musical _musicalInfo = new CodingQuiz_Musical("43455", 500, "4QS345", "2.5", "A.R.Rehman Musical",30);
            Console.WriteLine(_musicalInfo.GetEvent_Details());
        }
    }
}
