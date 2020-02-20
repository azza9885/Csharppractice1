using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Transaction : ITransaction
    {
        private string tcode;
        private string date;
        private double amount;

        public Transaction()
        {
            tcode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string a, string b, double c)
        {
            tcode = a;
            date = b;
            amount = c;

        }

        public double getamount()
        {
            return amount;
        }

        public override string ToString()
        {
            return string.Format("\n Transaction code is : {0} for date : {1} and for amount: {2}", tcode, date, getamount());
        }
    }
}
