using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentServices
{
    class PaymentProcessor
    {
        //1
        //THE DELEGATE - Points to different methods
        //When an event happens and a delegate is triggered,
        //all the methods associated with the delegate will take place
        public delegate void ProcessPaymentDelegate(Payment p);
        //We can take in anything of type payment
        //This include Payment objects, and it's child classes
        //Meaning we can pass in a Cash or Card Payment too.

        //2
        //THE EVENT - What will trigger the delegate and all the methods inside it.
        public event ProcessPaymentDelegate PaymentMade;

        //3
        //Does the actual event/delegate call
        protected virtual void OnPaymentMade(Payment p) 
        {
            //check if there are methods assigned
            if(PaymentMade != null) 
            {
                //if there are methods assigned to the delegate,
                //run them
                PaymentMade(p);
                //THIS IS WHERE THE METHODS ASSIGNED TO THE DELEGATE ACTUALLY RUN
            }
        }

        //4 Assigning Methods to our delegate
        public void ProcessThePayment(Payment p) 
        {
            //here we assigned the method to the delegate.
            //we didnt run the method, because you can see
            //there are no brackets
            //The order in which you assign methods to a delegate matters
            //they run in the order you added them.
            PaymentMade += SavePayment;
            PaymentMade += DisplayAndCheckTotal;

            //5
            //Call the delegate/run the event
            OnPaymentMade(p);
        }

  

        //method to save a payment to our list util
        private void SavePayment(Payment p) 
        {
            //Checks if it is a cash or card payment and adds it to the list in ListUtil
            if (p is CashPayment)//Checking the type, returns a boolean
            {
                //Casting p from Payment to Cash Payment
                ListUtil.CashTransactions.Add(p as CashPayment);
            }
            else
            {
                ListUtil.CardTransactions.Add(p as CardPayment);
            }

            System.Windows.Forms.MessageBox.Show("Payment Added");
        }

        //THis method displays the last added payment
        //It will let us know when the total of all payments
        //is over R5000
        private void DisplayAndCheckTotal(Payment p) 
        {
            //the total of all transactions
            double total = GetTotal();

            //The string that we display
            string output = "";

            //Adding the last payment's info to the string
            output += "Order ID: " + p.OrderID + "\n"
                   + "Reference : " + p.Reference + "\n"
                   + "Amount : R" + p.Amount;

            //if the total is over R5000, add this line to the string we display from
            if(total >= 5000) 
            {
                output += "\nTotal of all Payments is over R5000 (R " + total + ")";
            }

            //displays the string with the info in a messagebox.
            System.Windows.Forms.MessageBox.Show(output);

        }

        //This method calculates the total of all transactions that we have so far
        private double GetTotal() 
        {
            double total = 0;
            foreach (CashPayment cashPayment in ListUtil.CashTransactions)
            {
                total += cashPayment.Amount;

                //+= is the same as saying this
                //total = total + cashPayment.Amount;
            }

            //we don't need to reset total to 0, because this is the total of both lists
            foreach (CardPayment cardPayment in ListUtil.CardTransactions)
            {
                total += cardPayment.Amount;
            }

            //returns the total
            return total;
        }
    }
}
