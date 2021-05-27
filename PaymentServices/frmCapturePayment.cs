using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentServices
{
    public partial class frmCapturePayment : Form
    {
        
        public frmCapturePayment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //Fields for the parent, we can store them before doing stuff specific to the children
            int orderID = Convert.ToInt32(txbOrder.Text);
            DateTime date = DateTime.Now;
            double amount = Convert.ToDouble(txbAmount.Text);
            string refernce = txbReference.Text;
            
            //Checking whats selected, and creating an object depending on that
            if (cmbPaymentType.SelectedItem.Equals("Cash"))
            {
                // cash object
                double tendered = Convert.ToDouble(txbTendered.Text);
                double change = Convert.ToDouble(txbChange.Text);
                string currency = txbCurrency.Text;

                //created object
                CashPayment cashP = new CashPayment(tendered, change, currency, orderID, date, amount, refernce);

                //wont have orderID, Date, amount
                CashPayment cashP2 = new CashPayment(tendered, change, currency, refernce);
                
                //storing the object in a util class so that it can be accessed by other classes
                ListUtil.cashTransactions.Add(cashP);
                ListUtil.payments.Add(cashP);

                MessageBox.Show("Cash Payment Created \n" + "Amount R: " + cashP.Amount);

            }
            else
            {
                // card object
                string holderName = txbHolder.Text;
                string lastFour = txbLastFour.Text;
                string provider = txbProvider.Text;

                //created object
                CardPayment cardP = new CardPayment(holderName, lastFour, provider, orderID, date, amount, refernce);
                //storing the object in a util class so that it can be accessed by other classes
                ListUtil.cardTransactions.Add(cardP);
                ListUtil.payments.Add(cardP);

                MessageBox.Show("Card Payment Created \n" + "Amount R: " + cardP.Amount);
            }
        }

        //Showing/hiding UI
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedItem.Equals("Cash"))
            {
                pnlCash.Visible = true;
                pnlCard.Visible= false;
            } else
            {
                pnlCash.Visible = false;
                pnlCard.Visible = true;
            }
        }

        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            frmViewPayments frmView = new frmViewPayments();//
            frmView.Show();
        }
    }
}
