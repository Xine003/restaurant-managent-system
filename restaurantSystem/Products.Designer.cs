namespace restaurantSystem
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.addProducts_btn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.productsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 577);
            this.panel1.TabIndex = 0;
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.productsPanel.BackgroundImage = global::restaurantSystem.Properties.Resources.Rectangle_373;
            this.productsPanel.Controls.Add(this.addProducts_btn);
            this.productsPanel.Controls.Add(this.label1);
            this.productsPanel.Location = new System.Drawing.Point(24, 12);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(1243, 565);
            this.productsPanel.TabIndex = 0;
            this.productsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.productsPanel_Paint);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.BackgroundImage = global::restaurantSystem.Properties.Resources.plus_1;
            this.addProducts_btn.Location = new System.Drawing.Point(1178, 17);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(30, 23);
            this.addProducts_btn.TabIndex = 1;
            this.addProducts_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.addProducts_btn_Paint);
            this.addProducts_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addProducts);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1037, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1296, 577);
            this.Controls.Add(this.panel1);
            this.Name = "Products";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            this.productsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addProducts_btn;
    }
}