using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class CashPayment : Payment
    {
        public double Tendered { get; set; }

        public double Change { get; set; }

        public string  Currency { get; set; }

        public CashPayment(double tendered, double change, string currency,
            int orderID, DateTime date, double amount, string reference) 
            : base(orderID, date, amount, reference)
        {
            Tendered = tendered;
            Change = change;
            Currency = currency;
        }
    }
}
