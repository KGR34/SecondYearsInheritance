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

        private void frmViewPayments_Load(object sender, EventArgs e)
        {
            lstCardPayments.Items.Clear();
            foreach (CardPayment c in ListUtil.cardTransactions)
            {
                lstCardPayments.Items.Add(c.OrderID + " - " + c.Amount);
            }

            lstCashPayments.Items.Clear();
            foreach (CashPayment c in ListUtil.cashTransactions)
            {
                lstCashPayments.Items.Add(c.OrderID + " - " + c.Amount);
            }
        }
    }
}
