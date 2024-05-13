namespace restaurantSystem
{
    partial class Cashier
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
            this.dateTime_label = new System.Windows.Forms.Label();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.orderList_btn = new System.Windows.Forms.Button();
            this.tableReservation_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dateTime_label);
            this.panel1.Controls.Add(this.dashboard_panel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 751);
            this.panel1.TabIndex = 39;
            // 
            // dateTime_label
            // 
            this.dateTime_label.AutoSize = true;
            this.dateTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTime_label.Location = new System.Drawing.Point(260, 96);
            this.dateTime_label.Name = "dateTime_label";
            this.dateTime_label.Size = new System.Drawing.Size(252, 26);
            this.dateTime_label.TabIndex = 6;
            this.dateTime_label.Text = "MM/DD/YYYY 00:00:00 ";
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_panel.Location = new System.Drawing.Point(223, 127);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(1314, 624);
            this.dashboard_panel.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(258, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 42);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::restaurantSystem.Properties.Resources.Line_1;
            this.pictureBox1.Location = new System.Drawing.Point(214, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1328, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::restaurantSystem.Properties.Resources.navbar1;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.logOut_btn);
            this.panel2.Controls.Add(this.orderList_btn);
            this.panel2.Controls.Add(this.tableReservation_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 751);
            this.panel2.TabIndex = 2;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.Transparent;
            this.logOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut_btn.Location = new System.Drawing.Point(0, 653);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOut_btn.Size = new System.Drawing.Size(213, 49);
            this.logOut_btn.TabIndex = 7;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // orderList_btn
            // 
            this.orderList_btn.BackColor = System.Drawing.Color.Transparent;
            this.orderList_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderList_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderList_btn.Location = new System.Drawing.Point(0, 382);
            this.orderList_btn.Name = "orderList_btn";
            this.orderList_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderList_btn.Size = new System.Drawing.Size(213, 49);
            this.orderList_btn.TabIndex = 6;
            this.orderList_btn.Text = "Payment";
            this.orderList_btn.UseVisualStyleBackColor = false;
            this.orderList_btn.Click += new System.EventHandler(this.orderList_btn_Click);
            // 
            // tableReservation_btn
            // 
            this.tableReservation_btn.BackColor = System.Drawing.Color.Transparent;
            this.tableReservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tableReservation_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableReservation_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableReservation_btn.Location = new System.Drawing.Point(0, 333);
            this.tableReservation_btn.Name = "tableReservation_btn";
            this.tableReservation_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableReservation_btn.Size = new System.Drawing.Size(213, 49);
            this.tableReservation_btn.TabIndex = 5;
            this.tableReservation_btn.Text = "Table Reservation";
            this.tableReservation_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hi Employee!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(62, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.home_btn.Location = new System.Drawing.Point(0, 284);
            this.home_btn.Name = "home_btn";
            this.home_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.home_btn.Size = new System.Drawing.Size(213, 49);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "New Order";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1540, 751);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tableReservation_btn;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Button orderList_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.Label dateTime_label;
        private System.Windows.Forms.Button button1;
    }
}