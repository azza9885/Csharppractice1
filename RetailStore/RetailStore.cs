using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    public class RetailStore
    {
        private double receiptNumber;
        private string dateOfPurchase;
        private double customerNumber;
        private string customerNameandAddress;
        private string customerPhoneNumber;
        private double itemNumber;
        private string itemDescription;
        private decimal unitPrice;
        private int quantityPurchased;

        //Constructor
        public RetailStore(double receiptNum,string purchaseDate,double customerNum,string customerDetails,string customerPh,double itemNum,
            string itemDesc,decimal priceOfUnit,int quantityBought)
        {
            ReceiptNumber = receiptNum;
            DateofPurchase = purchaseDate;
            CustomerNumber = customerNum;
            CustomerNameandAddress = customerDetails;
            CustomerPhoneNumber = customerPh;
            ItemNumber = itemNum;
            ItemDescription = itemDesc;
            UnitPrice = priceOfUnit;
            QuantityPurchased = quantityBought;
        }
        //Properties definitions
        public double ReceiptNumber 
        { 
            get { return receiptNumber; } 
            
            set { 
                if(value > 0)
                {
                    receiptNumber = value;
                }

                else
                {
                    Console.WriteLine(" Receipt Number has to be a non-zero number!!!");

                }
            }
                
        }

        public string DateofPurchase
        {
            get { return dateOfPurchase; }

            set { dateOfPurchase = value; }
        }

        public double CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }

                else
                {
                    Console.WriteLine(" Customer Number has to be a non-zero number!!!");

                }
            }
        }

        public string CustomerNameandAddress
        {
            get { return customerNameandAddress; }
            set { customerNameandAddress = value; }
        }

        public string CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set { customerPhoneNumber = value;}
        }

        public double ItemNumber
        {
            get { return itemNumber; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }

                else
                {
                    Console.WriteLine(" Enter a valid item number!!!");

                }
            }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }

                else
                {
                    Console.WriteLine(" Enter a valid Price Value!!!");

                }
            }
        }

        public int QuantityPurchased
        {
            get { return quantityPurchased; }
            set
            {
                if (value > 0 )
                {
                    quantityPurchased = value;
                }

                else
                {
                    Console.WriteLine(" Enter a valid Price Value!!!");

                }
            }
        }

        //Method definitions

        public decimal Total_Shopping_expense()
        {
            return UnitPrice * Convert.ToDecimal(QuantityPurchased);
        }

        public override string ToString()
        {
            return "Customer " + CustomerNameandAddress +
                    "\n Phone : " + CustomerPhoneNumber +
                    "\n Total Purchases : " + Total_Shopping_expense().ToString("c");
        }
    }
}
