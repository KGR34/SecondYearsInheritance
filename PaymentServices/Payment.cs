using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    public abstract class Payment
    {
        // Holds whats common in all payments
        public int OrderID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; } 
        public string Reference { get; set; }

        // is for when we know all values
        public Payment(int orderID, DateTime date, double amount, string reference)
        {
            OrderID = orderID;
            Date = date;
            Reference = reference;
            Amount = amount;
        }

        //default
        public Payment() 
        { }

        //payment obj where we only know the reference
        public Payment(string reference) 
        {
            Reference = reference;
        }

        public abstract string Display();

    }
}
