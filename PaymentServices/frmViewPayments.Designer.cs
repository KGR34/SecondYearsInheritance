
namespace PaymentServices
{
    partial class frmViewPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCardPayments = new System.Windows.Forms.ListBox();
            this.lstCashPayments = new System.Windows.Forms.ListBox();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTendered = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblLast4 = new System.Windows.Forms.Label();
            this.lblHolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpPayment.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCardPayments
            // 
            this.lstCardPayments.FormattingEnabled = true;
            this.lstCardPayments.ItemHeight = 20;
            this.lstCardPayments.Location = new System.Drawing.Point(65, 63);
            this.lstCardPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCardPayments.Name = "lstCardPayments";
            this.lstCardPayments.Size = new System.Drawing.Size(383, 224);
            this.lstCardPayments.TabIndex = 0;
            this.lstCardPayments.SelectedIndexChanged += new System.EventHandler(this.lstCardPayments_SelectedIndexChanged);
            // 
            // lstCashPayments
            // 
            this.lstCashPayments.FormattingEnabled = true;
            this.lstCashPayments.ItemHeight = 20;
            this.lstCashPayments.Location = new System.Drawing.Point(65, 324);
            this.lstCashPayments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCashPayments.Name = "lstCashPayments";
            this.lstCashPayments.Size = new System.Drawing.Size(383, 224);
            this.lstCashPayments.TabIndex = 1;
            this.lstCashPayments.SelectedIndexChanged += new System.EventHandler(this.lstCashPayments_SelectedIndexChanged);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.pnlCash);
            this.grpPayment.Controls.Add(this.pnlCard);
            this.grpPayment.Controls.Add(this.label1);
            this.grpPayment.Controls.Add(this.lblReference);
            this.grpPayment.Controls.Add(this.lblDate);
            this.grpPayment.Controls.Add(this.lblOrderID);
            this.grpPayment.Location = new System.Drawing.Point(514, 63);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(298, 485);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Details";
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.lblCurrency);
            this.pnlCash.Controls.Add(this.lblChange);
            this.pnlCash.Controls.Add(this.lblTendered);
            this.pnlCash.Location = new System.Drawing.Point(20, 331);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(250, 104);
            this.pnlCash.TabIndex = 5;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(13, 68);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(66, 20);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(13, 44);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(59, 20);
            this.lblChange.TabIndex = 1;
            this.lblChange.Text = "Change";
            // 
            // lblTendered
            // 
            this.lblTendered.AutoSize = true;
            this.lblTendered.Location = new System.Drawing.Point(13, 20);
            this.lblTendered.Name = "lblTendered";
            this.lblTendered.Size = new System.Drawing.Size(71, 20);
            this.lblTendered.TabIndex = 0;
            this.lblTendered.Text = "Tendered";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.lblProvider);
            this.pnlCard.Controls.Add(this.lblLast4);
            this.pnlCard.Controls.Add(this.lblHolder);
            this.pnlCard.Location = new System.Drawing.Point(20, 185);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(250, 104);
            this.pnlCard.TabIndex = 4;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(13, 68);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(64, 20);
            this.lblProvider.TabIndex = 2;
            this.lblProvider.Text = "Provider";
            // 
            // lblLast4
            // 
            this.lblLast4.AutoSize = true;
            this.lblLast4.Location = new System.Drawing.Point(13, 44);
            this.lblLast4.Name = "lblLast4";
            this.lblLast4.Size = new System.Drawing.Size(111, 20);
            this.lblLast4.TabIndex = 1;
            this.lblLast4.Text = "Last Four Digits";
            // 
            // lblHolder
            // 
            this.lblHolder.AutoSize = true;
            this.lblHolder.Location = new System.Drawing.Point(13, 20);
            this.lblHolder.Name = "lblHolder";
            this.lblHolder.Size = new System.Drawing.Size(55, 20);
            this.lblHolder.TabIndex = 0;
            this.lblHolder.Text = "Holder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount:";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Location = new System.Drawing.Point(20, 119);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(86, 20);
            this.lblReference.TabIndex = 2;
            this.lblReference.Text = "Reference : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 69);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(20, 39);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(69, 20);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // frmViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 622);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.lstCashPayments);
            this.Controls.Add(this.lstCardPayments);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmViewPayments";
            this.Text = "frmViewPayments";
            this.Load += new System.EventHandler(this.frmViewPayments_Load);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCardPayments;
        private System.Windows.Forms.ListBox lstCashPayments;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTendered;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblLast4;
        private System.Windows.Forms.Label lblHolder;
    }
}