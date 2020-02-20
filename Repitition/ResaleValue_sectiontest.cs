using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repitition
{
    public class ResaleValue_sectiontest
    {
        //private variable
        private double itemPrice_wholesale;

        //constructor
        public ResaleValue_sectiontest(double wholesaleItemPrice)
        {
            ItemPrice_wholesale = wholesaleItemPrice;
        }
        
        //property definition for private variable
        public double ItemPrice_wholesale 
        {
            get {return itemPrice_wholesale; }
            set {itemPrice_wholesale=value; }
        }

        public double Final_MarkupPrice(double percentageValue)
        {
            double markup_PriceDifference = (ItemPrice_wholesale * percentageValue) / 100;

            double final_Markup_Price = ItemPrice_wholesale + markup_PriceDifference;

            return final_Markup_Price;
        }
    }
}
