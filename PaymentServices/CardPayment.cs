using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class CardPayment : Payment
    {
        public string HolderName { get; set; }
        public string LastFourDigits { get; set; }
        public string Provider { get; set; }

        //the constructor of a child class needs to take in the fields for it's parent 
        //as well as itself
        
        public CardPayment(string holderName, string lastFourDigits, string provider, //child fields
                int orderID, DateTime date, double amount, string reference //parent fields
            ) : base(orderID, date, amount, reference)
        {
            HolderName = holderName;
            LastFourDigits = lastFourDigits;
            Provider = provider;
        }
    }
}
