using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RetailStore
{
    [TestClass]
    public class RetailStore_Test
    {
        [TestMethod]
        public void ReceiptNumberPositiveTest()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 3131, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if(rStore.ReceiptNumber > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The receipt number is : " + rStore.ReceiptNumber);
            }

            else
            {
                Console.WriteLine("Receipt Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }

        [TestMethod]
        public void ReceiptNumberNegativeTest()
        {
            RetailStore rStore = new RetailStore(0, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 3131, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.ReceiptNumber > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The receipt number is : " + rStore.ReceiptNumber);
            }

            else
            {
                Console.WriteLine("Receipt Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }
        

        [TestMethod]

        public void CustomerNumber_PositiveTest()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 3131, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.CustomerNumber > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Customer number is : " + rStore.CustomerNumber);
            }

            else
            {
                Console.WriteLine("Customer Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }
        [TestMethod]
        public void CustomerNumber_NegativeTest()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 0, "John Wick from Paris", "9191919191", 3131, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.CustomerNumber > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Customer number is : " + rStore.CustomerNumber);
            }

            else
            {
                Console.WriteLine("Customer Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }

        [TestMethod]

        public void ItemNumber_PositiveTest1()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.ItemNumber > 0 && rStore.ItemNumber < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Customer number is : " + rStore.ItemNumber);
            }

            else 
            {
                Console.WriteLine("Customer Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }
        [TestMethod]
        public void ItemNumber_PositiveTest2()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 1, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.ItemNumber > 0 && rStore.ItemNumber < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Customer number is : " + rStore.ItemNumber);
            }

            else
            {
                Console.WriteLine("Item Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }
        [TestMethod]
        public void ItemNumber_NegativeTest1()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 0, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.ItemNumber > 0 && rStore.ItemNumber < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Item number is : " + rStore.ItemNumber);
            }

            else
            {
                Console.WriteLine("Item Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }
        [TestMethod]
        public void ItemNumber_NegativeTest2()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9999, "Apple Watch Series 4", 455, 3);
            bool TestPass;
            if (rStore.ItemNumber > 0 && rStore.ItemNumber < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Item number is : " + rStore.ItemNumber);
            }

            else
            {
                Console.WriteLine("Item Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }

        [TestMethod]
        public void UnitNumber_PositiveTest1()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 1, 3);
            bool TestPass;
            if (rStore.UnitPrice > 0 && rStore.UnitPrice < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Unit Price is : " + rStore.UnitPrice);
            }

            else
            {
                Console.WriteLine("Customer Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }

        [TestMethod]
        public void UnitNumber_PositiveTest2()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4",9998, 3);
            bool TestPass;
            if (rStore.UnitPrice > 0 && rStore.UnitPrice < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Unit Price is : " + rStore.UnitPrice);
            }

            else
            {
                Console.WriteLine("Customer Number is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }

        [TestMethod]
        public void UnitNumber_NegativeTest1()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 0, 3);
            bool TestPass;
            if (rStore.UnitPrice > 0 && rStore.UnitPrice < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Unit Price is : " + rStore.UnitPrice);
            }

            else
            {
                Console.WriteLine("Unit Price is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }

        [TestMethod]
        public void UnitNumber_NegativeTest2()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 9999, 3);
            bool TestPass;
            if (rStore.UnitPrice > 0 && rStore.UnitPrice < 9999)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Unit Price is : " + rStore.UnitPrice);
            }

            else
            {
                Console.WriteLine("Unit Price is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }

        [TestMethod]
        public void Quantity_PositiveTest()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 1, 1);
            bool TestPass;
            if (rStore.QuantityPurchased > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Quantity is : " + rStore.QuantityPurchased);
            }

            else
            {
                Console.WriteLine("Quantity is Invalid!!!");
                TestPass = false;
            }

            Assert.IsTrue(TestPass);
        }

        [TestMethod]
        public void Quantity_NegativeTest()
        {
            RetailStore rStore = new RetailStore(23456, "21-Jan-2020", 34567, "John Wick from Paris", "9191919191", 9998, "Apple Watch Series 4", 1, 0);
            bool TestPass;
            if (rStore.QuantityPurchased > 0)
            {
                TestPass = true;
                Decimal Expenditure = rStore.Total_Shopping_expense();
                String Expenditure_Currency = String.Format("{0:C}", Expenditure);
                Console.WriteLine("Total Shopping Expense is : " + Expenditure_Currency);
                Console.WriteLine(rStore);
                Console.WriteLine("The Quantity is : " + rStore.QuantityPurchased);
            }

            else
            {
                Console.WriteLine("Quantity is Invalid!!!");
                TestPass = false;
            }

            Assert.IsFalse(TestPass);
        }
    }
}
