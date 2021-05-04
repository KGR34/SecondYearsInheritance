
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
            this.SuspendLayout();
            // 
            // lstCardPayments
            // 
            this.lstCardPayments.FormattingEnabled = true;
            this.lstCardPayments.ItemHeight = 15;
            this.lstCardPayments.Location = new System.Drawing.Point(57, 47);
            this.lstCardPayments.Name = "lstCardPayments";
            this.lstCardPayments.Size = new System.Drawing.Size(120, 94);
            this.lstCardPayments.TabIndex = 0;
            // 
            // lstCashPayments
            // 
            this.lstCashPayments.FormattingEnabled = true;
            this.lstCashPayments.ItemHeight = 15;
            this.lstCashPayments.Location = new System.Drawing.Point(267, 47);
            this.lstCashPayments.Name = "lstCashPayments";
            this.lstCashPayments.Size = new System.Drawing.Size(120, 94);
            this.lstCashPayments.TabIndex = 1;
            // 
            // frmViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 267);
            this.Controls.Add(this.lstCashPayments);
            this.Controls.Add(this.lstCardPayments);
            this.Name = "frmViewPayments";
            this.Text = "frmViewPayments";
            this.Load += new System.EventHandler(this.frmViewPayments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCardPayments;
        private System.Windows.Forms.ListBox lstCashPayments;
    }
}