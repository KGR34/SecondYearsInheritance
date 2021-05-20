using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaymentServices
{
    public partial class frmViewPayments : Form
    {

        public frmViewPayments()
        {
            InitializeComponent();
        }

        //Populates the list boxes when the form is loaded
        private void frmViewPayments_Load(object sender, EventArgs e)
        {
            //hides the details since nothing is selected when the form is loaded
            HideEverything();

            //populates the list boxes
            lstCardPayments.Items.Clear();
            //loops through the card transactions in the listutil class and adds them to the list box of card payments
            foreach (CardPayment payment in ListUtil.cardTransactions)
            {
                lstCardPayments.Items.Add(payment.OrderID + " -  R" + payment.Amount);
            }

            lstCashPayments.Items.Clear();
            foreach (CashPayment payment in ListUtil.cashTransactions)
            {
                lstCashPayments.Items.Add(payment.OrderID + " -  R" + payment.Amount);
            }
        }

        private void HideEverything() 
        {
            //Everything is in the GroupBox, so we can hide just that
            grpPayment.Visible = false;
        }

        private void lstCardPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpPayment.Visible = true;
            pnlCard.Visible = true;
            pnlCash.Visible = false;

            //We need the selected Item from the listbox and the list of transactions
            //because we just looped through the array to populate the listbox,
            //we can assume that what the user selects in the listbox is in the same position
            //as the list

            int position = lstCardPayments.SelectedIndex;

            //take card payment from the list, at this specific position, 
            //and store it in an object
            CardPayment cardPayment = ListUtil.cardTransactions[position];

            //we set the labels to show the info about a payment
            lblOrderID.Text = "Order ID : " + cardPayment.OrderID.ToString();
            lblDate.Text = "Order Date : " + cardPayment.Date.ToString();
            label1.Text = "Amount: R" + cardPayment.Amount.ToString();
            lblReference.Text = "Reference : " + cardPayment.Reference;
            lblHolder.Text = "Holder :" + cardPayment.HolderName;
            lblLast4.Text = "Last 4: " + cardPayment.LastFourDigits;
            lblProvider.Text = "Provider : " + cardPayment.Provider;

        }

        private void lstCashPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpPayment.Visible = true;
            pnlCard.Visible = false;
            pnlCash.Visible = true;

            //We need the selected Item from the listbox and the list of transactions
            //because we just looped through the array to populate the listbox,
            //we can assume that what the user selects in the listbox is in the same position
            //as the list

            int position = lstCashPayments.SelectedIndex;

            //take card payment from the list, at this specific position, 
            //and store it in an object

            CashPayment cashPayment = ListUtil.cashTransactions[position];


            //we set the labels to show the info about a payment
            lblOrderID.Text = "Order ID : " + cashPayment.OrderID.ToString();
            lblDate.Text = "Order Date : " + cashPayment.Date.ToString();
            label1.Text = "Amount: R" + cashPayment.Amount.ToString();
            lblReference.Text = "Reference : " + cashPayment.Reference;
            lblTendered.Text = "Tendered : R" + cashPayment.Tendered.ToString();
            lblChange.Text = "Change : R" + cashPayment.Change.ToString();
            lblCurrency.Text = cashPayment.Currency;
        }
    }
}
