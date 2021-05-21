using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    //AN EXTENTION OF THE PARENT CLASS - PAYMENT
    public class CashPayment : Payment
    {
        public double Tendered { get; set; }
        public double Change { get; set; }
        public string Currency { get; set; }


        public CashPayment(double tendered, double change, string currency, //child fields
            int orderID, DateTime date, double amount, string reference // parent fields
            ) : base(orderID, date, amount, reference)
        {
            Tendered = tendered;
            Change = change;
            Currency = currency;
        }
    }
}
