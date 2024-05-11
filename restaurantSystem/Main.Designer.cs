﻿namespace restaurantSystem
{
    partial class Main
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
            this.label6 = new System.Windows.Forms.Label();
            this.dashboard_panel = new System.Windows.Forms.Panel();
            this.navbar = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.employee_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.foodcategory_btn = new System.Windows.Forms.Button();
            this.linepanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.dateTime_label);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dashboard_panel);
            this.panel1.Controls.Add(this.navbar);
            this.panel1.Controls.Add(this.linepanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1540, 751);
            this.panel1.TabIndex = 22;
            // 
            // dateTime_label
            // 
            this.dateTime_label.AutoSize = true;
            this.dateTime_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTime_label.Location = new System.Drawing.Point(256, 96);
            this.dateTime_label.Name = "dateTime_label";
            this.dateTime_label.Size = new System.Drawing.Size(252, 26);
            this.dateTime_label.TabIndex = 2;
            this.dateTime_label.Text = "MM/DD/YYYY 00:00:00 ";
            this.dateTime_label.Click += new System.EventHandler(this.dateTime_label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(258, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dashboard";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dashboard_panel
            // 
            this.dashboard_panel.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_panel.Location = new System.Drawing.Point(223, 127);
            this.dashboard_panel.Name = "dashboard_panel";
            this.dashboard_panel.Size = new System.Drawing.Size(1314, 624);
            this.dashboard_panel.TabIndex = 1;
            // 
            // navbar
            // 
            this.navbar.BackgroundImage = global::restaurantSystem.Properties.Resources.navbar1;
            this.navbar.Controls.Add(this.logout_btn);
            this.navbar.Controls.Add(this.products_btn);
            this.navbar.Controls.Add(this.employee_btn);
            this.navbar.Controls.Add(this.home_btn);
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.pictureBox2);
            this.navbar.Controls.Add(this.foodcategory_btn);
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(217, 751);
            this.navbar.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.logout_btn.Location = new System.Drawing.Point(0, 653);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(213, 60);
            this.logout_btn.TabIndex = 24;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click_1);
            // 
            // products_btn
            // 
            this.products_btn.BackColor = System.Drawing.Color.Transparent;
            this.products_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.ForeColor = System.Drawing.Color.Transparent;
            this.products_btn.Location = new System.Drawing.Point(0, 393);
            this.products_btn.Margin = new System.Windows.Forms.Padding(4);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(213, 54);
            this.products_btn.TabIndex = 23;
            this.products_btn.Text = "Products";
            this.products_btn.UseVisualStyleBackColor = false;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // employee_btn
            // 
            this.employee_btn.BackColor = System.Drawing.Color.Transparent;
            this.employee_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.employee_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.employee_btn.Location = new System.Drawing.Point(0, 448);
            this.employee_btn.Margin = new System.Windows.Forms.Padding(4);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(213, 60);
            this.employee_btn.TabIndex = 5;
            this.employee_btn.Text = "Employee";
            this.employee_btn.UseVisualStyleBackColor = false;
            this.employee_btn.Click += new System.EventHandler(this.user_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_btn.Location = new System.Drawing.Point(0, 284);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(213, 49);
            this.home_btn.TabIndex = 7;
            this.home_btn.Text = "Home";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.loadDashboard);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi Admin!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(62, 49);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 100);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // foodcategory_btn
            // 
            this.foodcategory_btn.BackColor = System.Drawing.Color.Transparent;
            this.foodcategory_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foodcategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foodcategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodcategory_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.foodcategory_btn.Location = new System.Drawing.Point(0, 330);
            this.foodcategory_btn.Margin = new System.Windows.Forms.Padding(4);
            this.foodcategory_btn.Name = "foodcategory_btn";
            this.foodcategory_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.foodcategory_btn.Size = new System.Drawing.Size(213, 62);
            this.foodcategory_btn.TabIndex = 4;
            this.foodcategory_btn.Text = "Category";
            this.foodcategory_btn.UseVisualStyleBackColor = false;
            this.foodcategory_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // linepanel
            // 
            this.linepanel.BackgroundImage = global::restaurantSystem.Properties.Resources.Line_1;
            this.linepanel.Location = new System.Drawing.Point(214, 83);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(1328, 10);
            this.linepanel.TabIndex = 0;
            this.linepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.linepanel_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1540, 751);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button foodcategory_btn;
        private System.Windows.Forms.Button employee_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Panel dashboard_panel;
        private System.Windows.Forms.Panel linepanel;
        private System.Windows.Forms.Label dateTime_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}