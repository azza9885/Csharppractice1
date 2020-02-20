using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics.End_of_Section_Exam
{
    class HomeLoan_Class : Loan_Class
    {
        private string _propertyAddress;
        private string _yearBuilt;
        private double _squareFootage;

        public HomeLoan_Class(string loanNum, string CusFirstName, string CusLastName, decimal Interest_Rate, decimal Loan_Amount, double LoanTerm_Years,string Address
            ,string yearOfBuilt,double squarefootDetail) : base(loanNum,CusFirstName,CusLastName,Interest_Rate,Loan_Amount,LoanTerm_Years)
        {
            PropertyAddress = Address;
            YearBuilt = yearOfBuilt;
            SquareFootage = squarefootDetail;
        }

        public string  PropertyAddress 
        {
            get 
            { 
                return _propertyAddress; 
            }
            set 
            {
                _propertyAddress=value; 
            } 
        }

        public string YearBuilt
        {
            get
            {
                return _yearBuilt;
            }
            set
            {
                _yearBuilt = value;
            }
        }

        public double SquareFootage
        {
            get
            {
                return _squareFootage;
            }
            set
            {
                _squareFootage = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n Property at the Address : " + PropertyAddress + "\t was built in the year " + YearBuilt + "\t and has a square footage of : " + SquareFootage +
                "\t and the interest for this purchase is : " + CalculateInterest().ToString("C");
        }

        public override decimal CalculateInterest()
        {
            decimal _loanPrincipal = LoanAmount + 5000M;
            double _loanDuration = NumberofYearsLoanTerm/12;
            decimal _interestrate_decimal = InterestRate / 100;

            decimal HomeLoan_Interest = (_interestrate_decimal /Convert.ToDecimal(_loanDuration)) * _loanPrincipal;
            return HomeLoan_Interest;
        }
    }
}
