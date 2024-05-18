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
            this.receiptProduct = new System.Windows.Forms.Panel();
            this.sampleDisplay = new System.Windows.Forms.TextBox();
            this.paymentPanel = new System.Windows.Forms.Panel();
            this.changeTb = new System.Windows.Forms.TextBox();
            this.paymentTb = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.orderSummary = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.num0btn = new System.Windows.Forms.Button();
            this.decimalbtn = new System.Windows.Forms.Button();
            this.num9btn = new System.Windows.Forms.Button();
            this.num8btn = new System.Windows.Forms.Button();
            this.num7btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.num6btn = new System.Windows.Forms.Button();
            this.num5btn = new System.Windows.Forms.Button();
            this.num4btn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.num3btn = new System.Windows.Forms.Button();
            this.num2btn = new System.Windows.Forms.Button();
            this.num1btn = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ORNo = new System.Windows.Forms.Label();
            this.insufficientCash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptProduct.SuspendLayout();
            this.paymentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptProduct
            // 
            this.receiptProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.receiptProduct.Controls.Add(this.insufficientCash);
            this.receiptProduct.Controls.Add(this.sampleDisplay);
            this.receiptProduct.Controls.Add(this.button3);
            this.receiptProduct.Controls.Add(this.num0btn);
            this.receiptProduct.Controls.Add(this.decimalbtn);
            this.receiptProduct.Controls.Add(this.num9btn);
            this.receiptProduct.Controls.Add(this.num8btn);
            this.receiptProduct.Controls.Add(this.num7btn);
            this.receiptProduct.Controls.Add(this.button5);
            this.receiptProduct.Controls.Add(this.num6btn);
            this.receiptProduct.Controls.Add(this.num5btn);
            this.receiptProduct.Controls.Add(this.num4btn);
            this.receiptProduct.Controls.Add(this.clearbtn);
            this.receiptProduct.Controls.Add(this.num3btn);
            this.receiptProduct.Controls.Add(this.num2btn);
            this.receiptProduct.Controls.Add(this.num1btn);
            this.receiptProduct.Controls.Add(this.num1);
            this.receiptProduct.Location = new System.Drawing.Point(884, 179);
            this.receiptProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiptProduct.Name = "receiptProduct";
            this.receiptProduct.Size = new System.Drawing.Size(368, 410);
            this.receiptProduct.TabIndex = 1;
            this.receiptProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.receiptProduct_Paint);
            // 
            // sampleDisplay
            // 
            this.sampleDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.sampleDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampleDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sampleDisplay.Location = new System.Drawing.Point(29, 50);
            this.sampleDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.sampleDisplay.Multiline = true;
            this.sampleDisplay.Name = "sampleDisplay";
            this.sampleDisplay.Size = new System.Drawing.Size(312, 49);
            this.sampleDisplay.TabIndex = 0;
            // 
            // paymentPanel
            // 
            this.paymentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.paymentPanel.Controls.Add(this.label1);
            this.paymentPanel.Controls.Add(this.ORNo);
            this.paymentPanel.Controls.Add(this.label2);
            this.paymentPanel.Controls.Add(this.changeTb);
            this.paymentPanel.Controls.Add(this.paymentTb);
            this.paymentPanel.Controls.Add(this.change);
            this.paymentPanel.Controls.Add(this.payment);
            this.paymentPanel.Location = new System.Drawing.Point(884, 26);
            this.paymentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentPanel.Name = "paymentPanel";
            this.paymentPanel.Size = new System.Drawing.Size(368, 133);
            this.paymentPanel.TabIndex = 1;
            this.paymentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paymentPanel_Paint);
            // 
            // changeTb
            // 
            this.changeTb.BackColor = System.Drawing.Color.Gray;
            this.changeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTb.ForeColor = System.Drawing.SystemColors.Window;
            this.changeTb.Location = new System.Drawing.Point(215, 67);
            this.changeTb.Multiline = true;
            this.changeTb.Name = "changeTb";
            this.changeTb.Size = new System.Drawing.Size(134, 40);
            this.changeTb.TabIndex = 3;
            // 
            // paymentTb
            // 
            this.paymentTb.BackColor = System.Drawing.Color.Gray;
            this.paymentTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTb.ForeColor = System.Drawing.SystemColors.Window;
            this.paymentTb.Location = new System.Drawing.Point(58, 68);
            this.paymentTb.Multiline = true;
            this.paymentTb.Name = "paymentTb";
            this.paymentTb.Size = new System.Drawing.Size(137, 40);
            this.paymentTb.TabIndex = 2;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.Transparent;
            this.change.Location = new System.Drawing.Point(210, 42);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(73, 22);
            this.change.TabIndex = 1;
            this.change.Text = "Change";
            this.change.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.ForeColor = System.Drawing.Color.Transparent;
            this.payment.Location = new System.Drawing.Point(45, 43);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(117, 22);
            this.payment.TabIndex = 0;
            this.payment.Text = "Total Amount";
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // orderSummary
            // 
            this.orderSummary.AutoScroll = true;
            this.orderSummary.BackColor = System.Drawing.Color.Transparent;
            this.orderSummary.Location = new System.Drawing.Point(30, 26);
            this.orderSummary.Name = "orderSummary";
            this.orderSummary.Size = new System.Drawing.Size(815, 563);
            this.orderSummary.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::restaurantSystem.Properties.Resources.Group_180__4_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(198, 338);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 62);
            this.button3.TabIndex = 39;
            this.button3.Text = "s";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // num0btn
            // 
            this.num0btn.BackColor = System.Drawing.Color.Transparent;
            this.num0btn.BackgroundImage = global::restaurantSystem.Properties.Resources.zero;
            this.num0btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num0btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0btn.ForeColor = System.Drawing.Color.Transparent;
            this.num0btn.Location = new System.Drawing.Point(109, 337);
            this.num0btn.Margin = new System.Windows.Forms.Padding(4);
            this.num0btn.Name = "num0btn";
            this.num0btn.Size = new System.Drawing.Size(67, 62);
            this.num0btn.TabIndex = 38;
            this.num0btn.Text = "0";
            this.num0btn.UseVisualStyleBackColor = false;
            this.num0btn.Click += new System.EventHandler(this.num0btn_Click);
            // 
            // decimalbtn
            // 
            this.decimalbtn.BackColor = System.Drawing.Color.Transparent;
            this.decimalbtn.BackgroundImage = global::restaurantSystem.Properties.Resources.period;
            this.decimalbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.decimalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalbtn.ForeColor = System.Drawing.Color.Transparent;
            this.decimalbtn.Location = new System.Drawing.Point(29, 337);
            this.decimalbtn.Margin = new System.Windows.Forms.Padding(4);
            this.decimalbtn.Name = "decimalbtn";
            this.decimalbtn.Size = new System.Drawing.Size(67, 62);
            this.decimalbtn.TabIndex = 37;
            this.decimalbtn.Text = ".";
            this.decimalbtn.UseVisualStyleBackColor = false;
            this.decimalbtn.Click += new System.EventHandler(this.decimalbtn_Click);
            // 
            // num9btn
            // 
            this.num9btn.BackColor = System.Drawing.Color.Transparent;
            this.num9btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_9;
            this.num9btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num9btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9btn.ForeColor = System.Drawing.Color.Transparent;
            this.num9btn.Location = new System.Drawing.Point(191, 262);
            this.num9btn.Margin = new System.Windows.Forms.Padding(4);
            this.num9btn.Name = "num9btn";
            this.num9btn.Size = new System.Drawing.Size(67, 62);
            this.num9btn.TabIndex = 31;
            this.num9btn.Text = "9";
            this.num9btn.UseVisualStyleBackColor = false;
            this.num9btn.Click += new System.EventHandler(this.num9btn_Click);
            // 
            // num8btn
            // 
            this.num8btn.BackColor = System.Drawing.Color.Transparent;
            this.num8btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_8;
            this.num8btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num8btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8btn.Location = new System.Drawing.Point(109, 262);
            this.num8btn.Margin = new System.Windows.Forms.Padding(4);
            this.num8btn.Name = "num8btn";
            this.num8btn.Size = new System.Drawing.Size(67, 62);
            this.num8btn.TabIndex = 30;
            this.num8btn.Text = "8";
            this.num8btn.UseVisualStyleBackColor = false;
            this.num8btn.Click += new System.EventHandler(this.num8btn_Click);
            // 
            // num7btn
            // 
            this.num7btn.BackColor = System.Drawing.Color.Transparent;
            this.num7btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_7;
            this.num7btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num7btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7btn.ForeColor = System.Drawing.Color.Transparent;
            this.num7btn.Location = new System.Drawing.Point(27, 262);
            this.num7btn.Margin = new System.Windows.Forms.Padding(4);
            this.num7btn.Name = "num7btn";
            this.num7btn.Size = new System.Drawing.Size(67, 62);
            this.num7btn.TabIndex = 29;
            this.num7btn.Text = "7";
            this.num7btn.UseVisualStyleBackColor = false;
            this.num7btn.Click += new System.EventHandler(this.num7btn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::restaurantSystem.Properties.Resources.Group_180__2_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(275, 188);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 136);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // num6btn
            // 
            this.num6btn.AllowDrop = true;
            this.num6btn.BackColor = System.Drawing.Color.Transparent;
            this.num6btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_6;
            this.num6btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num6btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6btn.ForeColor = System.Drawing.Color.Black;
            this.num6btn.Location = new System.Drawing.Point(191, 188);
            this.num6btn.Margin = new System.Windows.Forms.Padding(4);
            this.num6btn.Name = "num6btn";
            this.num6btn.Size = new System.Drawing.Size(67, 62);
            this.num6btn.TabIndex = 27;
            this.num6btn.Text = "6";
            this.num6btn.UseVisualStyleBackColor = false;
            this.num6btn.Click += new System.EventHandler(this.num6btn_Click);
            // 
            // num5btn
            // 
            this.num5btn.BackColor = System.Drawing.Color.Transparent;
            this.num5btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_5;
            this.num5btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.num5btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5btn.Location = new System.Drawing.Point(108, 188);
            this.num5btn.Margin = new System.Windows.Forms.Padding(4);
            this.num5btn.Name = "num5btn";
            this.num5btn.Size = new System.Drawing.Size(67, 62);
            this.num5btn.TabIndex = 26;
            this.num5btn.Text = "5";
            this.num5btn.UseVisualStyleBackColor = false;
            this.num5btn.Click += new System.EventHandler(this.num5btn_Click);
            // 
            // num4btn
            // 
            this.num4btn.BackColor = System.Drawing.Color.Transparent;
            this.num4btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_4;
            this.num4btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num4btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4btn.ForeColor = System.Drawing.Color.Transparent;
            this.num4btn.Location = new System.Drawing.Point(27, 188);
            this.num4btn.Margin = new System.Windows.Forms.Padding(4);
            this.num4btn.Name = "num4btn";
            this.num4btn.Size = new System.Drawing.Size(67, 62);
            this.num4btn.TabIndex = 25;
            this.num4btn.Text = "4";
            this.num4btn.UseVisualStyleBackColor = false;
            this.num4btn.Click += new System.EventHandler(this.num4btn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.Transparent;
            this.clearbtn.BackgroundImage = global::restaurantSystem.Properties.Resources.letter_c;
            this.clearbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.Transparent;
            this.clearbtn.Location = new System.Drawing.Point(275, 113);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(67, 62);
            this.clearbtn.TabIndex = 24;
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // num3btn
            // 
            this.num3btn.BackColor = System.Drawing.Color.Transparent;
            this.num3btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_3;
            this.num3btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num3btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3btn.ForeColor = System.Drawing.Color.Transparent;
            this.num3btn.Location = new System.Drawing.Point(191, 113);
            this.num3btn.Margin = new System.Windows.Forms.Padding(4);
            this.num3btn.Name = "num3btn";
            this.num3btn.Size = new System.Drawing.Size(67, 62);
            this.num3btn.TabIndex = 23;
            this.num3btn.Text = "3";
            this.num3btn.UseVisualStyleBackColor = false;
            this.num3btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // num2btn
            // 
            this.num2btn.BackColor = System.Drawing.Color.Transparent;
            this.num2btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_2;
            this.num2btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.num2btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2btn.ForeColor = System.Drawing.Color.Transparent;
            this.num2btn.Location = new System.Drawing.Point(109, 113);
            this.num2btn.Margin = new System.Windows.Forms.Padding(4);
            this.num2btn.Name = "num2btn";
            this.num2btn.Size = new System.Drawing.Size(67, 62);
            this.num2btn.TabIndex = 22;
            this.num2btn.Text = "2";
            this.num2btn.UseVisualStyleBackColor = false;
            this.num2btn.Click += new System.EventHandler(this.num2btn_Click);
            // 
            // num1btn
            // 
            this.num1btn.BackColor = System.Drawing.Color.Transparent;
            this.num1btn.BackgroundImage = global::restaurantSystem.Properties.Resources.number_1;
            this.num1btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.num1btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.num1btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1btn.ForeColor = System.Drawing.Color.Transparent;
            this.num1btn.Location = new System.Drawing.Point(27, 113);
            this.num1btn.Margin = new System.Windows.Forms.Padding(4);
            this.num1btn.Name = "num1btn";
            this.num1btn.Size = new System.Drawing.Size(67, 62);
            this.num1btn.TabIndex = 21;
            this.num1btn.Text = "1";
            this.num1btn.UseVisualStyleBackColor = false;
            this.num1btn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.BackgroundImage = global::restaurantSystem.Properties.Resources.number_1;
            this.num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.num1.Location = new System.Drawing.Point(83, 162);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(0, 0);
            this.num1.TabIndex = 0;
            this.num1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(104, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "OR No:";
            // 
            // ORNo
            // 
            this.ORNo.AutoSize = true;
            this.ORNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORNo.ForeColor = System.Drawing.Color.Transparent;
            this.ORNo.Location = new System.Drawing.Point(173, 18);
            this.ORNo.Name = "ORNo";
            this.ORNo.Size = new System.Drawing.Size(70, 22);
            this.ORNo.TabIndex = 6;
            this.ORNo.Text = "000000";
            this.ORNo.Click += new System.EventHandler(this.ORNo_Click);
            // 
            // insufficientCash
            // 
            this.insufficientCash.AutoSize = true;
            this.insufficientCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insufficientCash.ForeColor = System.Drawing.Color.Transparent;
            this.insufficientCash.Location = new System.Drawing.Point(105, 10);
            this.insufficientCash.Name = "insufficientCash";
            this.insufficientCash.Size = new System.Drawing.Size(130, 22);
            this.insufficientCash.TabIndex = 7;
            this.insufficientCash.Text = "........................";
            this.insufficientCash.Click += new System.EventHandler(this.insufficientCash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "₱";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1277, 626);
            this.Controls.Add(this.orderSummary);
            this.Controls.Add(this.paymentPanel);
            this.Controls.Add(this.receiptProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Receipt";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.receiptProduct.ResumeLayout(false);
            this.receiptProduct.PerformLayout();
            this.paymentPanel.ResumeLayout(false);
            this.paymentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel receiptProduct;
        private System.Windows.Forms.PictureBox num1;
        private System.Windows.Forms.Button num1btn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button num3btn;
        private System.Windows.Forms.Button num2btn;
        private System.Windows.Forms.Button num9btn;
        private System.Windows.Forms.Button num8btn;
        private System.Windows.Forms.Button num7btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button num6btn;
        private System.Windows.Forms.Button num5btn;
        private System.Windows.Forms.Button num4btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button num0btn;
        private System.Windows.Forms.Button decimalbtn;
        private System.Windows.Forms.TextBox sampleDisplay;
        private System.Windows.Forms.Panel paymentPanel;
        private System.Windows.Forms.Label payment;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.TextBox changeTb;
        private System.Windows.Forms.TextBox paymentTb;
        private System.Windows.Forms.FlowLayoutPanel orderSummary;
        private System.Windows.Forms.Label ORNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label insufficientCash;
        private System.Windows.Forms.Label label1;
    }
}