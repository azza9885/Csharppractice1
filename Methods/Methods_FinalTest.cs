using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Methods_FinalTest
    {
        //private variables
        private string _homeOwnerAddress;
        private decimal _priorYearHomeValue;

        public Methods_FinalTest(string _address,decimal _lastyr_HomeValue)
        {
            HomeOwnerAddress = _address;
            PriorYearHomeValue = _lastyr_HomeValue;

        }

        //properties definition
        public string HomeOwnerAddress 
        {
            get {return _homeOwnerAddress; }

            set {_homeOwnerAddress = value; } 
        
        }

        public decimal PriorYearHomeValue
        {
            get { return _priorYearHomeValue; }
            set { _priorYearHomeValue = value; }
        }

        public decimal CurrentYearHomeValue()
        {
            decimal difference_current_lastyear_value = 2.7M * PriorYearHomeValue / 100;
            return PriorYearHomeValue + difference_current_lastyear_value;
        }

        public decimal Taxable_Value()
        {
            decimal taxableValue_Home = CurrentYearHomeValue() - 25000M;
            return taxableValue_Home;
        }

        public static decimal MillageRate()
        {
            decimal _millageRatePercentage = 10.03M / 1000M * 100M;
            return _millageRatePercentage;
        }

        public decimal TaxesDue()
        {
            decimal _finalTaxesDue = Taxable_Value() * 1.003M / 100M;
            return _finalTaxesDue;
        }

        public override string ToString()
        {
            return "HomeOwnerAddress : " + HomeOwnerAddress +
                   "\n Last Year Assesed Home Value : " + PriorYearHomeValue.ToString("C") +
                   "\n Current Year Assesed Home Value : " + CurrentYearHomeValue().ToString("C") +
                   "\n Exemption : 25000$" +
                   "\n Taxable Value : " + Taxable_Value().ToString("C") +
                   "\n Millage Rate  :  " + MillageRate() + "%" +
                   "\n Taxes Due : " + TaxesDue().ToString("C");
        }
    }
}
