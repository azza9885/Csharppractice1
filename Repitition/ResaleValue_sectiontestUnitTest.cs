using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repitition
{
    [TestClass]
    public class ResaleValue_sectiontestUnitTest
    {
        [TestMethod]
        public void ResaleValue_UnitTest()
        {

            ResaleValue_sectiontest ReValue = new ResaleValue_sectiontest(100);
            double markuppercentage = 0 ;
            double finalMarkup_Price = 0 ;
            Console.WriteLine(" The original Wholesale Item price is 100$");
            Console.WriteLine(" \n  MarkUp Percentage(%) \t \t Markedup Price ");

            for (markuppercentage = 5; markuppercentage <= 10; markuppercentage++)
            {
                finalMarkup_Price = ReValue.Final_MarkupPrice(markuppercentage);
                Console.WriteLine($"\n  \t {markuppercentage}(%) \t \t \t   {finalMarkup_Price.ToString("c")} ");
            }
            

        }
    }
}
