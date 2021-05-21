using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    public class ListUtil
    {
        //when something is static, there can only be one instance of it.
        private static List<CardPayment> cardTransactions = new List<CardPayment>();
        private static List<CashPayment> cashTransactions = new List<CashPayment>();

        //You can use normal public static lists I just did it this way, with gets and sets
        public static List<CardPayment> CardTransactions { get => cardTransactions; set => cardTransactions = value; }
        public static List<CashPayment> CashTransactions { get => cashTransactions; set => cashTransactions = value; }
    }
}
