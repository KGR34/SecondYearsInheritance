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
                //new instance of the payment processor service
                PaymentProcessor paymentService = new PaymentProcessor();
                paymentService.ProcessThePayment(cashP);
            }
            else
            {
                // card object
                string holderName = txbHolder.Text;
                string lastFour = txbLastFour.Text;
                string provider = txbProvider.Text;

                //created object
                CardPayment cardP = new CardPayment(holderName, lastFour, provider, orderID, date, amount, refernce);
                PaymentProcessor paymentService = new PaymentProcessor();
                paymentService.ProcessThePayment(cardP);
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

        //Opens the form that allows us to view the payments we made
        private void btnViewPayments_Click(object sender, EventArgs e)
        {
            frmViewPayments frmView = new frmViewPayments();
            frmView.Show();
        }
    }
}
