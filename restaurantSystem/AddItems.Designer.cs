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
            this.i_price = new System.Windows.Forms.TextBox();
            this.i_name = new System.Windows.Forms.TextBox();
            this.i_category = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.additem_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // i_price
            // 
            this.i_price.Location = new System.Drawing.Point(44, 184);
            this.i_price.Margin = new System.Windows.Forms.Padding(4);
            this.i_price.Multiline = true;
            this.i_price.Name = "i_price";
            this.i_price.Size = new System.Drawing.Size(129, 25);
            this.i_price.TabIndex = 2;
            // 
            // i_name
            // 
            this.i_name.Location = new System.Drawing.Point(44, 116);
            this.i_name.Margin = new System.Windows.Forms.Padding(4);
            this.i_name.Multiline = true;
            this.i_name.Name = "i_name";
            this.i_name.Size = new System.Drawing.Size(278, 32);
            this.i_name.TabIndex = 0;
            this.i_name.TextChanged += new System.EventHandler(this.i_name_TextChanged);
            // 
            // i_category
            // 
            this.i_category.FormattingEnabled = true;
            this.i_category.Location = new System.Drawing.Point(180, 184);
            this.i_category.Name = "i_category";
            this.i_category.Size = new System.Drawing.Size(142, 24);
            this.i_category.TabIndex = 3;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(470, 243);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 40);
            this.back_btn.TabIndex = 10;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // additem_btn
            // 
            this.additem_btn.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additem_btn.Location = new System.Drawing.Point(366, 243);
            this.additem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.additem_btn.Name = "additem_btn";
            this.additem_btn.Size = new System.Drawing.Size(100, 40);
            this.additem_btn.TabIndex = 9;
            this.additem_btn.Text = "Add Item";
            this.additem_btn.UseVisualStyleBackColor = true;
            this.additem_btn.Click += new System.EventHandler(this.additem_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(177, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Category:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::restaurantSystem.Properties.Resources.Rectangle_3831;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(677, 337);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureProduct
            // 
            this.pictureProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictureProduct.Image = global::restaurantSystem.Properties.Resources.Group_1643;
            this.pictureProduct.Location = new System.Drawing.Point(366, 83);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(204, 153);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 15;
            this.pictureProduct.TabStop = false;
            this.pictureProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseImage);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(677, 337);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.additem_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.i_price);
            this.Controls.Add(this.i_name);
            this.Controls.Add(this.i_category);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox i_price;
        private System.Windows.Forms.TextBox i_name;
        private System.Windows.Forms.ComboBox i_category;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button additem_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureProduct;
    }
}