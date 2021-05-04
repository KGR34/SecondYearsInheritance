using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class ListUtil
    {
        public static List<CardPayment> cardTransactions = new List<CardPayment>();

        public static List<CashPayment> cashTransactions = new List<CashPayment>();

        public static string loggedInUser;
    }
}
