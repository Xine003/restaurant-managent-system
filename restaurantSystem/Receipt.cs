using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Renci.SshNet.Common;
using restaurantSystem.DesignCodes;
using System.Drawing.Printing;
using System.IO;

namespace restaurantSystem
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            DesignCodes.Borders.SetBorderRadius(orderSummary, 30);
            DesignCodes.Borders.SetBorderRadius(receiptProduct, 30);
            DesignCodes.Borders.SetBorderRadius(paymentPanel, 30);
            DisplayOrders(orderSummary);
            insufficientCash.Text = "";
        }


        private void orderSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }


        private void num1_Click(object sender, MouseEventArgs e, TextBox sampleDisplay)
        {
            PictureBox num1 = (PictureBox)sender;
            sampleDisplay.Text += num1.Tag.ToString();
        }



        private void num2_Click(object sender, MouseEventArgs e)
        {

        }

        private void num3_Click(object sender, MouseEventArgs e)
        {

        }

        private void clear_Click(object sender, MouseEventArgs e)
        {

        }

        private void num4_Click(object sender, MouseEventArgs e)
        {

        }

        private void num5_Click(object sender, MouseEventArgs e)
        {

        }

        private void num6_Click(object sender, MouseEventArgs e)
        {

        }

        private void delete_Click(object sender, MouseEventArgs e)
        {

        }

        private void decimal_Click(object sender, MouseEventArgs e)
        {

        }

        private void num0_Click(object sender, MouseEventArgs e)
        {

        }

        private void enter_Click(object sender, MouseEventArgs e)
        {

        }

       

        private void receiptProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num1btn.Text;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
                    }

        private void num2btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num2btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num3btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = "";
        }

        private void num4btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num4btn.Text;
        }

        private void num5btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num5btn.Text;
        }

        private void num6btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num6btn.Text;
        }

        private void num7btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num7btn.Text;
        }

        private void num8btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num8btn.Text;
        }

        private void num9btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num9btn.Text;
        }

        private void decimalbtn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + decimalbtn.Text;

        }

        private void num0btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num0btn.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sampleDisplay.Text.Length > 0)
            {
                sampleDisplay.Text = sampleDisplay.Text.Substring(0, sampleDisplay.Text.Length - 1);
            }
        }

        private void payment_Click(object sender, EventArgs e)
        {

        }

        private void paymentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }


        private void DisplayOrders(FlowLayoutPanel panel)
        {
            orderSummary.Controls.Clear();
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<OrderData> orders = dbHelper.GetOrderData();

            foreach (var order in orders)
            {
                Panel orderPanel = new Panel
                {
                    Width = 295,
                    Height = 200, 
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    BackgroundImage = Properties.Resources.logo, 
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                orderPanel.Click += (sender, e) =>
                {
                   
                    paymentTb.Text = order.TotalAmount.ToString("0.00");
                    ORNo.Text = order.ORNumber.ToString();
                };

                Borders.SetBorderRadius(orderPanel, 20);

          
                Panel innerPanel = new Panel
                {
                    Width = orderPanel.Width,
                    Height = 40,
                    BackColor = ColorTranslator.FromHtml("#526DCB"),
                    Dock = DockStyle.Top 
                };

                Label titleLabel = new Label
                {
                    Text = "Prestige Plate",
                    ForeColor = Color.White,
                    Font = new Font("Copperplate Gothic Light", 12, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill 
                };

                innerPanel.Controls.Add(titleLabel);


                int topMargin = 50;

                Font labelFont = new Font("Helvetica", 9, FontStyle.Regular);

                Label orNumberLabel = new Label
                {
                    Text = "OR Number: " + order.ORNumber,
                    AutoSize = true,
                    Top = topMargin,
                    Left = 148,
                    Font = labelFont,
                    BackColor = Color.Transparent
                };
                topMargin += orNumberLabel.Height;

                Label tableNumberLabel = new Label
                {
                    Text = "Table Number: " + order.TableNumber,
                    AutoSize = true,
                    Top = topMargin,
                    Left = 148,
                    Font = labelFont,
                    BackColor = Color.Transparent
                };
                topMargin += tableNumberLabel.Height;

                Label dateLabel = new Label
                {
                    Text = "Date: " + order.Date.ToString("yyyy-MM-dd"),
                    AutoSize = true,
                    Top = topMargin,
                    Left = 148,
                    Font = labelFont,
                    BackColor = Color.Transparent
                };
                topMargin += dateLabel.Height;

                Label timeLabel = new Label
                {
                    Text = "Time: " + order.Time.ToString("HH:mm:ss"),
                    AutoSize = true,
                    Top = topMargin,
                    Left = 148,
                    Font = labelFont,
                    BackColor = Color.Transparent
                };
                topMargin += timeLabel.Height;

                Label totalAmountLabel = new Label
                {
                    Text = "Total Amount:₱" + order.TotalAmount.ToString("0.00"),
                    AutoSize = true,
                    Top = topMargin,
                    Left = 148,
                    Font = labelFont,
                    BackColor = Color.Transparent
                };

                topMargin += totalAmountLabel.Height;

                // Create a panel below the total amount label
                Panel bottomPanel = new Panel
                {
                    Width = orderPanel.Width,
                    Height = 20,
                    BackColor = ColorTranslator.FromHtml("#526DCB"),
                   Dock = DockStyle.Bottom // Dock the bottom panel to the bottom of the orderPanel
                };

                orderPanel.Controls.Add(innerPanel); 
                orderPanel.Controls.Add(orNumberLabel);
                orderPanel.Controls.Add(tableNumberLabel);
                orderPanel.Controls.Add(dateLabel);
                orderPanel.Controls.Add(timeLabel);
                orderPanel.Controls.Add(totalAmountLabel);
                orderPanel.Controls.Add(bottomPanel); 

                panel.Controls.Add(orderPanel);
            }
        }


        private class DatabaseHelper
        {
            private string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";

            public List<OrderData> GetOrderData()
            {
                List<OrderData> orders = new List<OrderData>();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM ordertable GROUP BY ORNumber";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderData order = new OrderData()
                                {
                                    ORNumber = reader["ORNumber"].ToString(),
                                    TableNumber = reader["tableNumber"].ToString(),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Time = Convert.ToDateTime(reader["time"]),
                                    TotalAmount = Convert.ToDouble(reader["totalAmount"]),
                                    OrderID = Convert.ToInt32(reader["orderID"]),
                                    OrderName = reader["orderName"].ToString(),
                                    PerPrice = Convert.ToDouble(reader["perPrice"]),
                                    OrderQuantity = Convert.ToInt32(reader["orderQuantity"])
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }

                return orders;
            }

            public List<OrderData> GetOrderDataByORNumber(string orNumber)
            {
                List<OrderData> orders = new List<OrderData>();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM ordertable WHERE ORNumber = @ORNumber";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ORNumber", orNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderData order = new OrderData()
                                {
                                    ORNumber = reader["ORNumber"].ToString(),
                                    TableNumber = reader["tableNumber"].ToString(),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Time = Convert.ToDateTime(reader["time"]),
                                    TotalAmount = Convert.ToDouble(reader["totalAmount"]),
                                    OrderID = Convert.ToInt32(reader["orderID"]),
                                    OrderName = reader["orderName"].ToString(),
                                    PerPrice = Convert.ToDouble(reader["perPrice"]),
                                    OrderQuantity = Convert.ToInt32(reader["orderQuantity"]),
                                    Disc = Convert.ToInt32(reader["discount"]),
                                    subTotal = Convert.ToDouble(reader["subtotal"])
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }

                return orders;
            }

            public void InsertHistoryTransaction(string orNumber, string orderName, double perPrice, int orderQuantity, string tableNumber, double totalAmount, DateTime date, DateTime time, double cashTendered, double changeAmount, double Disc, double subTotal)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO historyTransaction (ORNumber, OrderName, PerPrice, OrderQuantity, TableNumber, TotalAmount, Date, Time, CashTendered, ChangeAmount, discount, subTotal) " +
                                 "VALUES (@ORNumber, @OrderName, @PerPrice, @OrderQuantity, @TableNumber, @TotalAmount, @Date, @Time, @CashTendered, @ChangeAmount, @Discount, @Subtotal)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ORNumber", orNumber);
                        cmd.Parameters.AddWithValue("@OrderName", orderName);
                        cmd.Parameters.AddWithValue("@PerPrice", perPrice);
                        cmd.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                        cmd.Parameters.AddWithValue("@TableNumber", tableNumber);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Time", time);
                        cmd.Parameters.AddWithValue("@CashTendered", cashTendered);
                        cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount);
                        cmd.Parameters.AddWithValue("@Discount", Disc);
                        cmd.Parameters.AddWithValue("@Subtotal", subTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public void DeleteHistoryTransactionByORNumber(string orNumber)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM orderTable WHERE ORNumber = @ORNumber";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ORNumber", orNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
            }


            public List<HistoryTransactionData> GetHistoryTransactionsByORNumber(string orNumber)
            {
                List<HistoryTransactionData> transactions = new List<HistoryTransactionData>();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM historyTransaction WHERE ORNumber = @ORNumber";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ORNumber", orNumber);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HistoryTransactionData transaction = new HistoryTransactionData()
                                {
                                    ORNumber = reader["ORNumber"].ToString(),
                                    OrderName = reader["orderName"].ToString(),
                                    PerPrice = Convert.ToDouble(reader["perPrice"]),
                                    OrderQuantity = Convert.ToInt32(reader["orderQuantity"]),
                                    TableNumber = reader["tableNumber"].ToString(),
                                    TotalAmount = Convert.ToDouble(reader["totalAmount"]),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Time = TimeSpan.Parse(reader["time"].ToString()), // Parse as TimeSpan
                                    CashTendered = Convert.ToDouble(reader["cashTendered"]),
                                    ChangeAmount = Convert.ToDouble(reader["changeAmount"]),
                                    Discount = reader["discount"].ToString(),
                                    subTotal = Convert.ToDouble(reader["subTotal"])

                                };
                                transactions.Add(transaction);
                            }
                        }
                    }
                }

                return transactions;
            }




        }

        public class HistoryTransactionData
        {
            public string ORNumber { get; set; }
            public string OrderName { get; set; }
            public double PerPrice { get; set; }
            public int OrderQuantity { get; set; }
            public string TableNumber { get; set; }
            public double TotalAmount { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan Time { get; set; } // Change the type to TimeSpan
            public double CashTendered { get; set; }
            public double ChangeAmount { get; set; }
            public string Discount { get; set; }
            public double subTotal { get; set; }
        }





        private class OrderData
        {
            public int OrderID { get; set; }
            public string ORNumber { get; set; }
            public string OrderName { get; set; }
            public double PerPrice { get; set; }
            public int OrderQuantity { get; set; }
            public string TableNumber { get; set; }
            public DateTime Date { get; set; }
            public DateTime Time { get; set; }
            public double TotalAmount { get; set; }
            public double Disc { get; set; }
            public double subTotal { get; set; }
        }




        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void ORNo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(paymentTb.Text) || string.IsNullOrEmpty(sampleDisplay.Text))
            {
                MessageBox.Show("Some fields are empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double totalAmount;
            if (!double.TryParse(paymentTb.Text, out totalAmount))
            {
                MessageBox.Show("Invalid total amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double cashTendered;
            if (!double.TryParse(sampleDisplay.Text, out cashTendered))
            {
                MessageBox.Show("Invalid cash tendered amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cashTendered < totalAmount)
            {
                insufficientCash.Text = "Insufficient Cash";
                insufficientCash.ForeColor = Color.Red;
                return; 
            }

            double change = cashTendered - totalAmount;
            if (change < 0)
            {
                MessageBox.Show("Change cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string message = $"Pay this bill? Total Amount: ₱{totalAmount.ToString("0.00")}";
            DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Payment successful, proceed with payment process
                double changes = change;
                changeTb.Text = changes.ToString("0.00");
                insufficientCash.Text = "Payment Successful!";
                insufficientCash.ForeColor = ColorTranslator.FromHtml("#95d5b2");



                DatabaseHelper dbHelper = new DatabaseHelper();
                string orNumber = ORNo.Text;
                List<OrderData> orders = dbHelper.GetOrderDataByORNumber(orNumber);

                foreach (var order in orders)
                {
                    dbHelper.InsertHistoryTransaction(
                        order.ORNumber,        
                        order.OrderName,       
                        order.PerPrice,        
                        order.OrderQuantity,   
                        order.TableNumber,     
                        order.TotalAmount,    
                        order.Date,          
                        order.Time,            
                        cashTendered,         
                        change,
                        order.Disc,
                        order.subTotal

                    );
                }

                dbHelper.DeleteHistoryTransactionByORNumber(orNumber);
                DisplayOrders(orderSummary);

                // Clear textboxes
                paymentTb.Text = "";
                sampleDisplay.Text = "";
                changeTb.Text = "";

                string ORNum = ORNo.Text;
                string receiptContent = GenerateReceiptContent(ORNum);
                ShowPrintPreview(receiptContent);
            }
            else
            {
                Console.WriteLine("Failed to pay.");
            }

        }

        private void DisplayOrders(Panel orderSummary)
        {
            
            orderSummary.Controls.Clear();
            DisplayOrders(orderSummary);

        }



        private void insufficientCash_Click(object sender, EventArgs e)
        {

        }

        private void sampleDisplay_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(sampleDisplay.Text, out decimal enteredAmount))
            {
                
                if (decimal.TryParse(paymentTb.Text, out decimal paymentAmount))
                {
           
                    decimal change = enteredAmount - paymentAmount;

                    changeTb.Text = change.ToString();
                }
                else
                {
                    
                    changeTb.Text = "Invalid payment amount";
                }
            }
            else
            {
           
                
            }
        }



        // reciept --------------------------------------

        private void ShowPrintPreview(string receiptContent)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                float yPos = 10;
                int count = 0;
                float leftMargin = 20;
                float topMargin = 40;
                float top = 20;
                string line = null;
                Font printFont = new Font("Arial", 11);
                SolidBrush myBrush = new SolidBrush(Color.Black);
                StringReader stringReader = new StringReader(receiptContent);

                float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

                // Calculate the width and height of the logo
                Image logo = Properties.Resources.logo1; // Assuming "logo" is the name of your resource
                float logoWidth = 200; // Adjust the width of the logo as needed
                float logoHeight = logo.Height * (logoWidth / logo.Width);

                float logoX = (e.MarginBounds.Left + e.MarginBounds.Right - logoWidth) / 2;


                e.Graphics.DrawImage(logo, logoX, top, logoWidth, logoHeight);


                topMargin += logoHeight + 10;

                while (count < linesPerPage && ((line = stringReader.ReadLine()) != null))
                {
                    yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(line, printFont, myBrush, leftMargin, yPos, new StringFormat());
                    count++;
                }

                if (line != null)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;

                myBrush.Dispose();
            };

            PaperSize customPaperSize = new PaperSize("Custom", 300, 1000);
            printDocument.DefaultPageSettings.PaperSize = customPaperSize;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to show the print preview: " + ex.Message);
            }
        }



        private string GenerateReceiptContent(string ORNumber)
        {
            StringBuilder sb = new StringBuilder();

            // Fetch data from the database based on ORNumber
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<HistoryTransactionData> transactions = dbHelper.GetHistoryTransactionsByORNumber(ORNumber);

           
                var firstTransaction = transactions[0];
                sb.AppendLine($"             OR Number: {firstTransaction.ORNumber}");
                    sb.AppendLine($"                    Table No: {firstTransaction.TableNumber}");
          
            sb.AppendLine($"             {firstTransaction.Date.ToString("yyyy-MM-dd")} , {firstTransaction.Time.Hours:D2}:{firstTransaction.Time.Minutes:D2}:{firstTransaction.Time.Seconds:D2}");
            sb.AppendLine("----------------------------------------------------");
            sb.AppendLine("                OFFICIAL RECEIPT");
            sb.AppendLine("----------------------------------------------------");


            foreach (var transaction in transactions)
                     {
                
                          sb.AppendLine($"{transaction.OrderName}");
                           sb.AppendLine($"{transaction.PerPrice} X {transaction.OrderQuantity}                           {transaction.PerPrice}");
                         }


                sb.AppendLine("----------------------------------------------------");
                sb.AppendLine($"Sub Total:                       ₱{firstTransaction.subTotal}");
                sb.AppendLine($"Cash Tendered:             ₱{firstTransaction.CashTendered}");
                sb.AppendLine($"Change:                          ₱{firstTransaction.ChangeAmount}");
                sb.AppendLine($"Discount:                        ₱{firstTransaction.Discount}");
                sb.AppendLine($"Total Amount:                 ₱{firstTransaction.TotalAmount}");
                sb.AppendLine("----------------------------------------------------");


            // Loop through product names


            sb.AppendLine("     Thank you for dining with us!");

            return sb.ToString();
        }





        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }

}
        

