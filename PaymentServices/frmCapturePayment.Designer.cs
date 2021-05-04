
namespace PaymentServices
{
    partial class frmCapturePayment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbOrder = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.txbReference = new System.Windows.Forms.TextBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txbProvider = new System.Windows.Forms.TextBox();
            this.txbLastFour = new System.Windows.Forms.TextBox();
            this.txbHolder = new System.Windows.Forms.TextBox();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txbCurrency = new System.Windows.Forms.TextBox();
            this.txbChange = new System.Windows.Forms.TextBox();
            this.txbTendered = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.pnlCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbOrder
            // 
            this.txbOrder.Location = new System.Drawing.Point(50, 36);
            this.txbOrder.Name = "txbOrder";
            this.txbOrder.PlaceholderText = "Order ID";
            this.txbOrder.Size = new System.Drawing.Size(100, 23);
            this.txbOrder.TabIndex = 0;
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(50, 79);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.PlaceholderText = "Amount";
            this.txbAmount.Size = new System.Drawing.Size(100, 23);
            this.txbAmount.TabIndex = 1;
            // 
            // txbReference
            // 
            this.txbReference.Location = new System.Drawing.Point(50, 121);
            this.txbReference.Name = "txbReference";
            this.txbReference.PlaceholderText = "Payment Reference";
            this.txbReference.Size = new System.Drawing.Size(100, 23);
            this.txbReference.TabIndex = 2;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.cmbPaymentType.Location = new System.Drawing.Point(50, 162);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(121, 23);
            this.cmbPaymentType.TabIndex = 3;
            this.cmbPaymentType.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentType_SelectedIndexChanged);
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.txbProvider);
            this.pnlCard.Controls.Add(this.txbLastFour);
            this.pnlCard.Controls.Add(this.txbHolder);
            this.pnlCard.Location = new System.Drawing.Point(281, 36);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(200, 100);
            this.pnlCard.TabIndex = 4;
            this.pnlCard.Visible = false;
            // 
            // txbProvider
            // 
            this.txbProvider.Location = new System.Drawing.Point(68, 70);
            this.txbProvider.Name = "txbProvider";
            this.txbProvider.PlaceholderText = "Provider";
            this.txbProvider.Size = new System.Drawing.Size(100, 23);
            this.txbProvider.TabIndex = 2;
            // 
            // txbLastFour
            // 
            this.txbLastFour.Location = new System.Drawing.Point(68, 40);
            this.txbLastFour.Name = "txbLastFour";
            this.txbLastFour.PlaceholderText = "Last 4";
            this.txbLastFour.Size = new System.Drawing.Size(100, 23);
            this.txbLastFour.TabIndex = 1;
            // 
            // txbHolder
            // 
            this.txbHolder.Location = new System.Drawing.Point(68, 10);
            this.txbHolder.Name = "txbHolder";
            this.txbHolder.PlaceholderText = "Cardholder";
            this.txbHolder.Size = new System.Drawing.Size(100, 23);
            this.txbHolder.TabIndex = 0;
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txbCurrency);
            this.pnlCash.Controls.Add(this.txbChange);
            this.pnlCash.Controls.Add(this.txbTendered);
            this.pnlCash.Location = new System.Drawing.Point(281, 162);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(200, 100);
            this.pnlCash.TabIndex = 5;
            this.pnlCash.Visible = false;
            // 
            // txbCurrency
            // 
            this.txbCurrency.Location = new System.Drawing.Point(68, 69);
            this.txbCurrency.Name = "txbCurrency";
            this.txbCurrency.PlaceholderText = "Currency";
            this.txbCurrency.Size = new System.Drawing.Size(100, 23);
            this.txbCurrency.TabIndex = 2;
            // 
            // txbChange
            // 
            this.txbChange.Location = new System.Drawing.Point(68, 40);
            this.txbChange.Name = "txbChange";
            this.txbChange.PlaceholderText = "Change";
            this.txbChange.Size = new System.Drawing.Size(100, 23);
            this.txbChange.TabIndex = 1;
            // 
            // txbTendered
            // 
            this.txbTendered.Location = new System.Drawing.Point(68, 11);
            this.txbTendered.Name = "txbTendered";
            this.txbTendered.PlaceholderText = "Tendered";
            this.txbTendered.Size = new System.Drawing.Size(100, 23);
            this.txbTendered.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(230, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmCapturePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 310);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.txbReference);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.txbOrder);
            this.Name = "frmCapturePayment";
            this.Text = "Form1";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOrder;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.TextBox txbReference;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txbProvider;
        private System.Windows.Forms.TextBox txbLastFour;
        private System.Windows.Forms.TextBox txbHolder;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.TextBox txbCurrency;
        private System.Windows.Forms.TextBox txbChange;
        private System.Windows.Forms.TextBox txbTendered;
        private System.Windows.Forms.Button btnSubmit;
    }
}

