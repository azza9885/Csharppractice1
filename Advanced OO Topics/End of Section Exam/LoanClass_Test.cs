using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advanced_OO_Topics.End_of_Section_Exam
{
    [TestClass]
    public class LoanClass_Test
    {
        [TestMethod]
        public void AutoLoan_Test()
        {
            AutoLoan_Class _aLoan = new AutoLoan_Class("A223444B9","Sanju","Samson",7.5M,12000M,4,"2014","Infiniti G35","Slate Blue");

            decimal AutoLoan_InterestAmount = _aLoan.CalculateInterest();
            Console.WriteLine(_aLoan);
            Assert.AreEqual(2925M,Convert.ToInt32(AutoLoan_InterestAmount));

        }
        [TestMethod]
        public void HomeLoan_Test()
        {
            HomeLoan_Class _hLoan = new HomeLoan_Class("H445444Z11","Yuzvendra","Chahal", 35M,210000M,30,"501 Parkview Street,D409 Collegeville,PA 19119","2010",1905);

            decimal HomeLoan_InterestAmount = _hLoan.CalculateInterest();
            Console.WriteLine(_hLoan);
            Assert.AreEqual(30100M, HomeLoan_InterestAmount);

        }
    }
}
