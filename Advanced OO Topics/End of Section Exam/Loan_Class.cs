using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics.End_of_Section_Exam
{
    abstract class Loan_Class
    {
        private string _loanNumber;
        private string _customerFirstName;
        private string _customerLastName;
        private decimal _interestRate;
        private decimal _loanAmount;
        private double _numberOfYearsinLoanTerm;

        public Loan_Class(string loanNum,string CusFirstName,string CusLastName,decimal Interest_Rate,decimal Loan_Amount,double LoanTerm_Years)
        {
            LoanNumber = loanNum;
            CustomerFirstName = CusFirstName;
            CustomerLastName = CusLastName;
            InterestRate = Interest_Rate;
            LoanAmount = Loan_Amount;
            NumberofYearsLoanTerm = LoanTerm_Years;

        }

        public string LoanNumber
        {

            get
            {
                return _loanNumber;
            }
            set
            {
                _loanNumber = value;
            }
        }

        public string CustomerFirstName
        {

            get
            {
                return _customerFirstName;
            }
            set
            {
                _customerFirstName = value;
            }
        }

        public string CustomerLastName
        {

            get
            {
                return _customerLastName;
            }
            set
            {
               _customerLastName = value;
            }
        }

        public decimal InterestRate
        {

            get
            {
                return _interestRate;
            }
            set
            {
               _interestRate = value;
            }
        }

        public decimal LoanAmount
        {

            get
            {
                return _loanAmount;
            }
            set
            {
               _loanAmount = value;
            }
        }

        public double NumberofYearsLoanTerm
        {

            get
            {
                return _numberOfYearsinLoanTerm;
            }
            set
            {
                _numberOfYearsinLoanTerm = value;
            }
        }

        public override string ToString()
        {
            return " \n For Customer with First Name  and Last Name " + CustomerFirstName + "\t" + CustomerLastName +
                   " \t the Loan Number is: " + LoanNumber +
                   " \t and for the Loan Amount: " + LoanAmount.ToString("C") + "\t and for a Loan Term of " + NumberofYearsLoanTerm + " years, the Interest rate is : " +
                   InterestRate + "%";


        }

        public abstract decimal CalculateInterest();
    }
}
