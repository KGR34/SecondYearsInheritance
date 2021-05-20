using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class ListUtil
    {
        //when something is static, there can only be one instance of it.


        public static List<CardPayment> cardTransactions = new List<CardPayment>();
        public static List<CashPayment> cashTransactions = new List<CashPayment>();
    }
}
