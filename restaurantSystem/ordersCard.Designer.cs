namespace restaurantSystem
{
    partial class ordersCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemname = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.ForeColor = System.Drawing.Color.Cornsilk;
            this.itemname.Location = new System.Drawing.Point(13, 12);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(72, 16);
            this.itemname.TabIndex = 0;
            this.itemname.Text = "Item Name";
            this.itemname.Click += new System.EventHandler(this.label1_Click);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantity.Location = new System.Drawing.Point(199, 14);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 1;
            this.quantity.Text = "Quantity";
            // 
            // ordersCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.itemname);
            this.Name = "ordersCard";
            this.Size = new System.Drawing.Size(258, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label quantity;
    }
}
