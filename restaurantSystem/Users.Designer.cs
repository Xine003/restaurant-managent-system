namespace restaurantSystem
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.removeuser_btn = new System.Windows.Forms.Button();
            this.employee_Table = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addProducts_btn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // removeuser_btn
            // 
            this.removeuser_btn.Location = new System.Drawing.Point(837, 13);
            this.removeuser_btn.Margin = new System.Windows.Forms.Padding(4);
            this.removeuser_btn.Name = "removeuser_btn";
            this.removeuser_btn.Size = new System.Drawing.Size(100, 28);
            this.removeuser_btn.TabIndex = 4;
            this.removeuser_btn.Text = "Remove";
            this.removeuser_btn.UseVisualStyleBackColor = true;
            this.removeuser_btn.Click += new System.EventHandler(this.removeuser_btn_Click);
            // 
            // employee_Table
            // 
            this.employee_Table.AllowUserToAddRows = false;
            this.employee_Table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.employee_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employee_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employee_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.employee_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employee_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employee_Table.DefaultCellStyle = dataGridViewCellStyle3;
            this.employee_Table.GridColor = System.Drawing.Color.White;
            this.employee_Table.Location = new System.Drawing.Point(12, 71);
            this.employee_Table.Name = "employee_Table";
            this.employee_Table.ReadOnly = true;
            this.employee_Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.employee_Table.RowHeadersVisible = false;
            this.employee_Table.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            this.employee_Table.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employee_Table.RowTemplate.Height = 24;
            this.employee_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.employee_Table.Size = new System.Drawing.Size(1272, 494);
            this.employee_Table.TabIndex = 5;
            this.employee_Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_Table_CellClick);
            this.employee_Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employee_Table_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1089, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Employee";
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.BackgroundImage = global::restaurantSystem.Properties.Resources.plus_1;
            this.addProducts_btn.Location = new System.Drawing.Point(1239, 28);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(30, 23);
            this.addProducts_btn.TabIndex = 8;
            this.addProducts_btn.Paint += new System.Windows.Forms.PaintEventHandler(this.addProducts_btn_Paint);
            this.addProducts_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addUser);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1296, 577);
            this.Controls.Add(this.addProducts_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employee_Table);
            this.Controls.Add(this.removeuser_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeuser_btn;
        private System.Windows.Forms.DataGridView employee_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addProducts_btn;
    }
}