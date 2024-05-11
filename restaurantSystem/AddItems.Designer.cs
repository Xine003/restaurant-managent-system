namespace restaurantSystem
{
    partial class AddItems
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
            this.bgpanel = new System.Windows.Forms.Panel();
            this.additem_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.i_name = new System.Windows.Forms.TextBox();
            this.i_price = new System.Windows.Forms.TextBox();
            this.bgpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bgpanel
            // 
            this.bgpanel.BackColor = System.Drawing.Color.Transparent;
            this.bgpanel.BackgroundImage = global::restaurantSystem.Properties.Resources.Rectangle_3831;
            this.bgpanel.Controls.Add(this.additem_btn);
            this.bgpanel.Controls.Add(this.panel1);
            this.bgpanel.Controls.Add(this.back_btn);
            this.bgpanel.Controls.Add(this.comboBox1);
            this.bgpanel.Controls.Add(this.i_name);
            this.bgpanel.Controls.Add(this.i_price);
            this.bgpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgpanel.Location = new System.Drawing.Point(0, 0);
            this.bgpanel.Name = "bgpanel";
            this.bgpanel.Size = new System.Drawing.Size(637, 358);
            this.bgpanel.TabIndex = 11;
            // 
            // additem_btn
            // 
            this.additem_btn.Location = new System.Drawing.Point(508, 251);
            this.additem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(90, 47);
            this.additem_btn.TabIndex = 9;
            this.additem_btn.Text = "Add Item";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(423, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 177);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::restaurantSystem.Properties.Resources.Group_1642;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(412, 251);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 47);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // i_name
            // 
            this.i_name.Location = new System.Drawing.Point(88, 121);
            this.i_name.Margin = new System.Windows.Forms.Padding(4);
            this.i_name.Multiline = true;
            this.i_name.Name = "i_name";
            this.i_name.Size = new System.Drawing.Size(278, 32);
            this.i_name.TabIndex = 0;
            this.i_name.TextChanged += new System.EventHandler(this.i_name_TextChanged);
            // 
            // i_price
            // 
            this.i_price.Location = new System.Drawing.Point(88, 176);
            this.i_price.Margin = new System.Windows.Forms.Padding(4);
            this.i_price.Multiline = true;
            this.i_price.Name = "i_price";
            this.i_price.Size = new System.Drawing.Size(145, 24);
            this.i_price.TabIndex = 2;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(637, 358);
            this.Controls.Add(this.bgpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.bgpanel.ResumeLayout(false);
            this.bgpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox i_name;
        private System.Windows.Forms.TextBox i_price;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Panel bgpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}