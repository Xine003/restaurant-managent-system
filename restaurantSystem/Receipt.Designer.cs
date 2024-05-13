namespace restaurantSystem
{
    partial class Receipt
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
            this.orderSummary = new System.Windows.Forms.Panel();
            this.receiptProduct = new System.Windows.Forms.Panel();
            this.customerID = new System.Windows.Forms.Label();
            this.tableNum = new System.Windows.Forms.Label();
            this.orderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderSummary
            // 
            this.orderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.orderSummary.Controls.Add(this.tableNum);
            this.orderSummary.Controls.Add(this.customerID);
            this.orderSummary.Location = new System.Drawing.Point(29, 30);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(571, 456);
            this.orderSummary.TabIndex = 0;
            this.orderSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.orderSummary_Paint);
            // 
            // receiptProduct
            // 
            this.receiptProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.receiptProduct.Location = new System.Drawing.Point(662, 30);
            this.receiptProduct.Name = "receiptProduct";
            this.receiptProduct.Size = new System.Drawing.Size(571, 456);
            this.receiptProduct.TabIndex = 1;
            // 
            // customerID
            // 
            this.customerID.AutoSize = true;
            this.customerID.BackColor = System.Drawing.Color.Transparent;
            this.customerID.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.customerID.Location = new System.Drawing.Point(249, 27);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(108, 23);
            this.customerID.TabIndex = 0;
            this.customerID.Text = "Customer id";
            this.customerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.BackColor = System.Drawing.Color.Transparent;
            this.tableNum.Font = new System.Drawing.Font("Leelawadee UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableNum.Location = new System.Drawing.Point(58, 27);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(84, 23);
            this.tableNum.TabIndex = 1;
            this.tableNum.Text = "Table no.";
            this.tableNum.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(1278, 530);
            this.Controls.Add(this.receiptProduct);
            this.Controls.Add(this.orderSummary);
            this.Name = "Receipt";
            this.Text = "Form1";
            this.orderSummary.ResumeLayout(false);
            this.orderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel orderSummary;
        private System.Windows.Forms.Panel receiptProduct;
        private System.Windows.Forms.Label customerID;
        private System.Windows.Forms.Label tableNum;
    }
}