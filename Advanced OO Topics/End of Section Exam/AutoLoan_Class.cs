using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OO_Topics.End_of_Section_Exam
{
    class AutoLoan_Class: Loan_Class
    {
        private string _yearBuilt;
        private string _make_N_model;
        private string _color;

        public AutoLoan_Class(string loanNum, string CusFirstName, string CusLastName, decimal Interest_Rate, decimal Loan_Amount, double LoanTerm_Years, string yearOfBuilt
            , string make_model, string vehileColor) : base(loanNum, CusFirstName, CusLastName, Interest_Rate, Loan_Amount, LoanTerm_Years)
        {
            YearBuilt = yearOfBuilt;
            Make_AND_Model = make_model;
            Color = vehileColor;
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

        public string Make_AND_Model
        {
            get
            {
                return _make_N_model;
            }
            set
            {
                _make_N_model = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n This Auto Vehicle was manufactured in : " + YearBuilt + "\t and has a Make and Model of  " + Make_AND_Model + "\t and is of the Color : " + Color + 
                "\t and the interest for this purchase is : " + CalculateInterest().ToString("C");
        }

        public override decimal CalculateInterest()
        {
            decimal _loanPrincipal = LoanAmount + 1000M;
            double _loanDuration = NumberofYearsLoanTerm/12;
            decimal _interestrate_decimal = InterestRate / 100;

            decimal AutoLoan_Interest = (_interestrate_decimal / Convert.ToDecimal(_loanDuration)) * _loanPrincipal;
            return AutoLoan_Interest;
        }
    }
}
