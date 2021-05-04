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
            CashPayment cashP;
            CardPayment cardP;

            int orderID = Convert.ToInt32(txbOrder.Text);
            double amount = Convert.ToDouble(txbAmount.Text);
            DateTime date = DateTime.Now;
            string reference = txbReference.Text;

            if (cmbPaymentType.SelectedItem.Equals("Cash"))
            {
                // cash object
                double tendered = Convert.ToDouble(txbTendered.Text);
                double change = Convert.ToDouble(txbChange.Text);
                string currency = txbCurrency.Text;
                cashP = new CashPayment(tendered, change, currency,
                    orderID, date, amount, reference);
                ListUtil.cashTransactions.Add(cashP);
            }
            else
            {
                // card object
                string cardholder = txbHolder.Text;
                string provider = txbProvider.Text;
                string lastFour = txbLastFour.Text;
                cardP = new CardPayment(orderID, date, amount, reference,
                    cardholder, lastFour, provider);
                ListUtil.cardTransactions.Add(cardP);
            }

            frmViewPayments fv = new frmViewPayments();
            this.Hide();
            fv.ShowDialog();
            this.Show();
        }

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
    }
}
