using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class CardPayment : Payment
    {
        public string HolderName { get; set; }
        public string LastFour { get; set; }
        public string Provider { get; set; }

        public CardPayment(int orderID, DateTime date, double amount, 
            string reference, string holderName, string lastFour, 
            string provider) : base (orderID, date, amount, reference)
        {
            HolderName = holderName;
            LastFour = lastFour;
            Provider = provider;
        }
    }
}
