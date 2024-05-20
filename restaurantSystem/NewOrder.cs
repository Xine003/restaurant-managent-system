using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurantSystem.DesignCodes;
using System.Data.SqlClient;

namespace restaurantSystem
{
    public partial class comboBox1 : Form
    {
        private DB db = new DB();
   
        private DataRow currentRow;
      


        public comboBox1()
        {
            InitializeComponent();
            PopulateFlowLayout();
            flowLayoutPanel.AutoScroll = true;
            DesignCodes.Borders.SetBorderRadius(confirmBtn, 20);
            DesignCodes.Borders.SetBorderRadius(cancelBtn, 20);
          
            confirmBtn.FlatAppearance.BorderSize = 0;
      
            cancelBtn.FlatAppearance.BorderSize = 0;
            UpdateComboBoxFromOrderTable();

            Font inter = new Font("Inter", 10);
            label1.Font = inter;
            label4.Font = inter;

            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void mainCourse_Click(object sender, EventArgs e)
        {
           
        }

      
        private void appetizer_Click(object sender, EventArgs e)
        {
            
        }

     
        private void dessert_Click(object sender, EventArgs e)
        {
            
        }

       
        private void beverages_Click(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        decimal totalAmount = 0;

        private void PopulateFlowLayout()
        {
          
            DataTable itemsTable = GetItemsFromDatabase();
            
            foreach (DataRow row in itemsTable.Rows)
            {
               
                Panel itemPanel = new Panel
                {
                    Width = 189,
                    Height = 250,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };
                DesignCodes.Borders.SetBorderRadius(itemPanel, 20);

                PictureBox pictureBox = new PictureBox
                {
                    Width = 172,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = ByteArrayToImage((byte[])row["productImage"]),
                    Tag = row["Name"].ToString(),
                    Location = new Point(8, 5)
                };
                DesignCodes.Borders.SetBorderRadius(pictureBox, 20);
                pictureBox.Click += Item_Click;

                Label nameLabel = new Label
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 150),
                    Font = new Font("Helvetica", 11, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = row["Price"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 175),
                    Font = new Font("Helvetica", 9, FontStyle.Italic)
                };

                Label quantityTextLabel = new Label
                {
                    Text = "Qty:",
                    AutoSize = true,
                    Location = new Point(5, 213)
                };


               TextBox quantityTextBox = new TextBox
                {
                    Width = 90,
                    Location = new Point(40, 210)
                };

             

                Button addButton = new Button
                {
                    Text = "Add",
                    Width = 48,
                    Location = new Point(quantityTextBox.Right + 5, 209),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = row
                };
                DesignCodes.Borders.SetBorderRadius(addButton, 20);

               
                addButton.Click += addButton_Click;

                itemPanel.Controls.Add(addButton);

                addButton.Click += (sender, e) =>
                {
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                    string price = currentRow["Price"].ToString();

                    if (int.TryParse(quantity, out int parsedQuantity) && parsedQuantity > 0)
                    {
                        Console.WriteLine($"{itemName} {price} {quantity}");

                        decimal totalPrice = Convert.ToDecimal(price) * parsedQuantity;
                        totalAmount += totalPrice;
                        totalAmountLabel.Text = totalAmount.ToString();
                        total_Amount.Text = totalAmount.ToString();

                        Label itemNameLabel = new Label
                        {
                            Text = $"{itemName}",
                            AutoSize = true,
                            ForeColor = Color.White,
                            TextAlign = ContentAlignment.MiddleLeft,
                            AutoEllipsis = true
                        };

                        Label perPriceLabel = new Label
                        {
                            Text = $"{price}",
                            AutoSize = true,
                            ForeColor = Color.White,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        Label quantityLabel = new Label
                        {
                            Text = $"{parsedQuantity}",
                            AutoSize = true,
                            ForeColor = Color.White,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        tableLayoutPanel1.Controls.Add(itemNameLabel, 0, tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.Controls.Add(perPriceLabel, 1, tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.Controls.Add(quantityLabel, 2, tableLayoutPanel1.RowCount - 1);

                        tableLayoutPanel1.RowCount++;
                        quantityTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid positive integer quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };



                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityTextLabel);
                itemPanel.Controls.Add(quantityTextBox);
                itemPanel.Controls.Add(addButton);

                itemPanel.Padding = new Padding(5, 0, 0, 0);
                flowLayoutPanel.Controls.Add(itemPanel);
            }
        }



        private DataTable GetItemsFromDatabase()
        {
            string query = "SELECT Name,Category,  Price, productImage FROM items";
            DataTable itemsTable = new DataTable();

            db.openConnection();

            using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(itemsTable);
                }
            }

            db.closeConnection();

            return itemsTable;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            string itemName = clickedPictureBox.Tag.ToString();
            Console.WriteLine(itemName);
        }



       



        private void addButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            DataRow row = clickedButton.Tag as DataRow;

            if (row != null)
            {
                currentRow = row;

                Panel itemPanel = clickedButton.Parent as Panel;

                TextBox quantityTextBox = itemPanel.Controls.OfType<TextBox>().FirstOrDefault();

                if (quantityTextBox != null)
                {
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                   
                  
                 
                    clickedButton.Click -= addButton_Click;

                  
                }
            }
        }

        private void mainCourse(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear(); // Clear existing controls
            FilterMainCourse();


        }

        private void appetizer(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            FilterAppetizer();


        }

        private void dessert(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            FilterDesserts();
        }

        private void beverages(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            FilterBeverages();


        }

     

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("Please input orders.", "Empty Orders", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            OR.Text = "OR No:" + randomNumber.ToString();
           string st =  totalAmountLabel.Text;

            string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";

            string query = "INSERT INTO orderTable (ORNumber, orderName, perPrice, orderQuantity, tableNumber, totalAmount, discount, subTotal) VALUES (@ORNumber, @OrderName, @PerPrice, @OrderQuantity, @tableNumber, @totalAmount, @Discount, @Subtotal)";

            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Select Table Number");
                return; 
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label label && label.Parent != null && label.Parent.Name == "tableLayoutPanel1")
                {
                    string itemName = tableLayoutPanel1.GetControlFromPosition(0, label.TabIndex)?.Text;
                    string perPrice = tableLayoutPanel1.GetControlFromPosition(1, label.TabIndex)?.Text;
                    string orderQuantity = tableLayoutPanel1.GetControlFromPosition(2, label.TabIndex)?.Text;
                    int tableNo = (int)comboBox2.SelectedItem;
                    string total = total_Amount.Text;
                    string discValue = label6.Text;

                    if (!string.IsNullOrEmpty(itemName) && !string.IsNullOrEmpty(perPrice) && !string.IsNullOrEmpty(orderQuantity))
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();
                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@ORNumber", randomNumber);
                                command.Parameters.AddWithValue("@OrderName", itemName);
                                command.Parameters.AddWithValue("@PerPrice", perPrice);
                                command.Parameters.AddWithValue("@OrderQuantity", orderQuantity);
                                command.Parameters.AddWithValue("@tableNumber", tableNo);
                                command.Parameters.AddWithValue("@totalAmount", total);
                                command.Parameters.AddWithValue("@Discount", discValue);
                                command.Parameters.AddWithValue("@Subtotal", st);
                                command.ExecuteNonQuery();
                                
                            }
                        }

                      

                    }
                }
            }

            string updateQuery = "UPDATE discount SET `limit` = `limit` - 1 WHERE disc_code = @DiscountCode";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@DiscountCode", textBox1.Text);
                    updateCommand.ExecuteNonQuery();
                }
            }


            MessageBox.Show("Order Confirmed");
            tableLayoutPanel1.Controls.Clear();
            totalAmountLabel.Text = "0.00";
            OR.Text = "New Order";
            comboBox2.SelectedIndex = -1;
            label6.Text = "";
            textBox1.Text = "";
            total_Amount.Text = "";
            UpdateComboBoxFromOrderTable();

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void totalAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            totalAmountLabel.Text = "0.00";
            OR.Text = "Official Reciept";
            total_Amount.Text = "0.00";
            textBox1.Text = "";
            comboBox2.SelectedIndex = -1;
        }





        //for main course only

        private DataTable GetItemsFromDatabase(string category)
        {
            string query = $"SELECT Name, Category, Price, productImage FROM items WHERE Category = '{category}'";
            DataTable itemsTable = new DataTable();

            db.openConnection();

            using (MySqlCommand command = new MySqlCommand(query, db.getConnection()))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(itemsTable);
                }
            }

            db.closeConnection();

            return itemsTable;
        }

        private DataTable GetAppetizerItemsFromDatabase()
        {
            return GetItemsFromDatabase("Appetizer");
        }

        private DataTable GetBeveragesItemsFromDatabase()
        {
            return GetItemsFromDatabase("Beverages");
        }

        private DataTable GetDessertsItemsFromDatabase()
        {
            return GetItemsFromDatabase("Desserts");
        }
        private DataTable GetMainCourseItemsFromDatabase()
        {
            return GetItemsFromDatabase("Main Course");
        }



        private void FilterMainCourse()
        {
            DataTable mainCourseItemsTable = GetMainCourseItemsFromDatabase(); // Assuming you have a method to get main course items from the database

            foreach (DataRow row in mainCourseItemsTable.Rows)
            {
                Panel itemPanel = new Panel
                {
                    Width = 189,
                    Height = 250,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };
                DesignCodes.Borders.SetBorderRadius(itemPanel, 20);

                PictureBox pictureBox = new PictureBox
                {
                    Width = 172,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = ByteArrayToImage((byte[])row["productImage"]),
                    Tag = row["Name"].ToString(),
                    Location = new Point(8, 5)
                };
                DesignCodes.Borders.SetBorderRadius(pictureBox, 20);
                pictureBox.Click += Item_Click;

                Label nameLabel = new Label
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 150),
                    Font = new Font("Helvetica", 11, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = row["Price"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 175),
                    Font = new Font("Helvetica", 9, FontStyle.Italic)
                };

                Label quantityTextLabel = new Label
                {
                    Text = "Qty:",
                    AutoSize = true,
                    Location = new Point(5, 213)
                };

                TextBox quantityTextBox = new TextBox
                {
                    Width = 90,
                    Location = new Point(40, 210)
                };

                Button addButton = new Button
                {
                    Text = "Add",
                    Width = 48,
                    Location = new Point(quantityTextBox.Right + 5, 209),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = row
                };
                DesignCodes.Borders.SetBorderRadius(addButton, 20);

                addButton.Click += (s, ev) =>
                {
                    DataRow currentRow = (DataRow)((Button)s).Tag;
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                    string price = currentRow["Price"].ToString();
                    Console.WriteLine($"{itemName} {price} {quantity}");

                    decimal totalPrice = Convert.ToDecimal(price) * Convert.ToDecimal(quantity);
                    totalAmount += totalPrice;
                    totalAmountLabel.Text = totalAmount.ToString();
                    total_Amount.Text = totalAmount.ToString();

                    Label itemNameLabel = new Label
                    {
                        Text = $"{itemName}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true
                    };

                    Label perPriceLabel = new Label
                    {
                        Text = $"{price}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label quantityLabel = new Label
                    {
                        Text = $"{quantity}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    tableLayoutPanel1.Controls.Add(itemNameLabel, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(perPriceLabel, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(quantityLabel, 2, tableLayoutPanel1.RowCount - 1);


                    tableLayoutPanel1.RowCount++;


                    quantityTextBox.Text = "";
                };

                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityTextLabel);
                itemPanel.Controls.Add(quantityTextBox);
                itemPanel.Controls.Add(addButton);

                itemPanel.Padding = new Padding(5, 0, 0, 0);
                flowLayoutPanel.Controls.Add(itemPanel);
            }
        }

        private void FilterAppetizer()
        {
            DataTable mainCourseItemsTable = GetAppetizerItemsFromDatabase(); // Assuming you have a method to get main course items from the database

            foreach (DataRow row in mainCourseItemsTable.Rows)
            {
                Panel itemPanel = new Panel
                {
                    Width = 189,
                    Height = 250,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };
                DesignCodes.Borders.SetBorderRadius(itemPanel, 20);

                PictureBox pictureBox = new PictureBox
                {
                    Width = 172,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = ByteArrayToImage((byte[])row["productImage"]),
                    Tag = row["Name"].ToString(),
                    Location = new Point(8, 5)
                };
                DesignCodes.Borders.SetBorderRadius(pictureBox, 20);
                pictureBox.Click += Item_Click;

                Label nameLabel = new Label
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 150),
                    Font = new Font("Helvetica", 11, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = row["Price"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 175),
                    Font = new Font("Helvetica", 9, FontStyle.Italic)
                };

                Label quantityTextLabel = new Label
                {
                    Text = "Qty:",
                    AutoSize = true,
                    Location = new Point(5, 213)
                };

                TextBox quantityTextBox = new TextBox
                {
                    Width = 90,
                    Location = new Point(40, 210)
                };

                Button addButton = new Button
                {
                    Text = "Add",
                    Width = 48,
                    Location = new Point(quantityTextBox.Right + 5, 209),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = row
                };
                DesignCodes.Borders.SetBorderRadius(addButton, 20);

                addButton.Click += (s, ev) =>
                {
                    DataRow currentRow = (DataRow)((Button)s).Tag;
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                    string price = currentRow["Price"].ToString();
                    Console.WriteLine($"{itemName} {price} {quantity}");

                    decimal totalPrice = Convert.ToDecimal(price) * Convert.ToDecimal(quantity);
                    totalAmount += totalPrice;
                    totalAmountLabel.Text = totalAmount.ToString();
                    total_Amount.Text = totalAmount.ToString();

                    Label itemNameLabel = new Label
                    {
                        Text = $"{itemName}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true
                    };

                    Label perPriceLabel = new Label
                    {
                        Text = $"{price}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label quantityLabel = new Label
                    {
                        Text = $"{quantity}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    tableLayoutPanel1.Controls.Add(itemNameLabel, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(perPriceLabel, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(quantityLabel, 2, tableLayoutPanel1.RowCount - 1);


                    tableLayoutPanel1.RowCount++;


                    quantityTextBox.Text = "";
                };

                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityTextLabel);
                itemPanel.Controls.Add(quantityTextBox);
                itemPanel.Controls.Add(addButton);

                itemPanel.Padding = new Padding(5, 0, 0, 0);
                flowLayoutPanel.Controls.Add(itemPanel);
            }
        }

        private void FilterDesserts()
        {
            DataTable mainCourseItemsTable = GetDessertsItemsFromDatabase(); 

            foreach (DataRow row in mainCourseItemsTable.Rows)
            {
                Panel itemPanel = new Panel
                {
                    Width = 189,
                    Height = 250,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };
                DesignCodes.Borders.SetBorderRadius(itemPanel, 20);

                PictureBox pictureBox = new PictureBox
                {
                    Width = 172,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = ByteArrayToImage((byte[])row["productImage"]),
                    Tag = row["Name"].ToString(),
                    Location = new Point(8, 5)
                };
                DesignCodes.Borders.SetBorderRadius(pictureBox, 20);
                pictureBox.Click += Item_Click;

                Label nameLabel = new Label
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 150),
                    Font = new Font("Helvetica", 11, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = row["Price"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 175),
                    Font = new Font("Helvetica", 9, FontStyle.Italic)
                };

                Label quantityTextLabel = new Label
                {
                    Text = "Qty:",
                    AutoSize = true,
                    Location = new Point(5, 213)
                };

                TextBox quantityTextBox = new TextBox
                {
                    Width = 90,
                    Location = new Point(40, 210)
                };

                Button addButton = new Button
                {
                    Text = "Add",
                    Width = 48,
                    Location = new Point(quantityTextBox.Right + 5, 209),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = row
                };
                DesignCodes.Borders.SetBorderRadius(addButton, 20);

                addButton.Click += (s, ev) =>
                {
                    DataRow currentRow = (DataRow)((Button)s).Tag;
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                    string price = currentRow["Price"].ToString();
                    Console.WriteLine($"{itemName} {price} {quantity}");

                    decimal totalPrice = Convert.ToDecimal(price) * Convert.ToDecimal(quantity);
                    totalAmount += totalPrice;
                    totalAmountLabel.Text = totalAmount.ToString();
                    total_Amount.Text = totalAmount.ToString();

                    Label itemNameLabel = new Label
                    {
                        Text = $"{itemName}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true
                    };

                    Label perPriceLabel = new Label
                    {
                        Text = $"{price}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label quantityLabel = new Label
                    {
                        Text = $"{quantity}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    tableLayoutPanel1.Controls.Add(itemNameLabel, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(perPriceLabel, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(quantityLabel, 2, tableLayoutPanel1.RowCount - 1);


                    tableLayoutPanel1.RowCount++;


                    quantityTextBox.Text = "";
                };

                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityTextLabel);
                itemPanel.Controls.Add(quantityTextBox);
                itemPanel.Controls.Add(addButton);

                itemPanel.Padding = new Padding(5, 0, 0, 0);
                flowLayoutPanel.Controls.Add(itemPanel);
            }
        }

        private void FilterBeverages()
        {
            DataTable mainCourseItemsTable = GetBeveragesItemsFromDatabase(); // Assuming you have a method to get main course items from the database

            foreach (DataRow row in mainCourseItemsTable.Rows)
            {
                Panel itemPanel = new Panel
                {
                    Width = 189,
                    Height = 250,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };
                DesignCodes.Borders.SetBorderRadius(itemPanel, 20);

                PictureBox pictureBox = new PictureBox
                {
                    Width = 172,
                    Height = 140,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = ByteArrayToImage((byte[])row["productImage"]),
                    Tag = row["Name"].ToString(),
                    Location = new Point(8, 5)
                };
                DesignCodes.Borders.SetBorderRadius(pictureBox, 20);
                pictureBox.Click += Item_Click;

                Label nameLabel = new Label
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 150),
                    Font = new Font("Helvetica", 11, FontStyle.Bold)
                };

                Label priceLabel = new Label
                {
                    Text = row["Price"].ToString(),
                    AutoSize = true,
                    Location = new Point(5, 175),
                    Font = new Font("Helvetica", 9, FontStyle.Italic)
                };

                Label quantityTextLabel = new Label
                {
                    Text = "Qty:",
                    AutoSize = true,
                    Location = new Point(5, 213)
                };

                TextBox quantityTextBox = new TextBox
                {
                    Width = 90,
                    Location = new Point(40, 210)
                };

                Button addButton = new Button
                {
                    Text = "Add",
                    Width = 48,
                    Location = new Point(quantityTextBox.Right + 5, 209),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = row
                };
                DesignCodes.Borders.SetBorderRadius(addButton, 20);

                addButton.Click += (s, ev) =>
                {
                    DataRow currentRow = (DataRow)((Button)s).Tag;
                    string itemName = currentRow["Name"].ToString();
                    string quantity = quantityTextBox.Text;
                    string price = currentRow["Price"].ToString();
                    Console.WriteLine($"{itemName} {price} {quantity}");

                    decimal totalPrice = Convert.ToDecimal(price) * Convert.ToDecimal(quantity);
                    totalAmount += totalPrice;
                    totalAmountLabel.Text = totalAmount.ToString();
                    total_Amount.Text = totalAmount.ToString();

                    Label itemNameLabel = new Label
                    {
                        Text = $"{itemName}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true
                    };

                    Label perPriceLabel = new Label
                    {
                        Text = $"{price}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    Label quantityLabel = new Label
                    {
                        Text = $"{quantity}",
                        AutoSize = true,
                        ForeColor = Color.White,
                        TextAlign = ContentAlignment.MiddleLeft
                    };

                    tableLayoutPanel1.Controls.Add(itemNameLabel, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(perPriceLabel, 1, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(quantityLabel, 2, tableLayoutPanel1.RowCount - 1);


                    tableLayoutPanel1.RowCount++;


                    quantityTextBox.Text = "";
                };

                itemPanel.Controls.Add(pictureBox);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(quantityTextLabel);
                itemPanel.Controls.Add(quantityTextBox);
                itemPanel.Controls.Add(addButton);

                itemPanel.Padding = new Padding(5, 0, 0, 0);
                flowLayoutPanel.Controls.Add(itemPanel);
            }
        }

        private void UpdateComboBoxFromOrderTable()
        {
            // Populate the combo box with numbers 1 to 12
           comboBox2.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }

            // Retrieve the numbers already present in the tableNumber column
            List<int> usedNumbers = new List<int>();
            string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";
            string query = "SELECT DISTINCT tableNumber FROM orderTable";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tableNumber;
                            if (int.TryParse(reader["tableNumber"].ToString(), out tableNumber))
                            {
                                usedNumbers.Add(tableNumber);
                            }
                        }
                    }
                }
            }

            foreach (int number in usedNumbers)
            {
                if (comboBox2.Items.Contains(number))
                {
                    comboBox2.Items.Remove(number);
                }
            }
        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string inputCode = textBox1.Text;
                CheckDiscountCode(inputCode);
            
                e.Handled = true;
            }

        }

        public void CheckDiscountCode(string code)
        {
            string subTotal = totalAmountLabel.Text;
            string query = "SELECT disc_value, `limit` FROM discount WHERE disc_code = @DiscCode";

            using (MySqlConnection connection = db.getConnection())
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DiscCode", code);

                try
                {
                    db.openConnection();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal subtotal = Convert.ToDecimal(subTotal);
                            decimal discValue = reader.GetDecimal(0); // Get disc_value from the query result
                            int limit = reader.GetInt32(1); // Get the limit from the query result

                            if (limit <= 0)
                            {
                                MessageBox.Show("Number of limits exceeded for this discount code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return; // Stop further processing
                            }

                            decimal dividedValue = discValue / 100;
                            decimal ttlamnt = subtotal * dividedValue;
                            decimal totalCost = subtotal - ttlamnt;
                            total_Amount.Text = totalCost.ToString();
                            label6.Text = ttlamnt.ToString("F2");

                         
                        }
                        else
                        {
                            MessageBox.Show("No matching discount code found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    label6.Text = "An error occurred. Please try again later.";
                    // Log the exception details
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    db.closeConnection();
                }
            }
        }

        private void total_Amount_Click(object sender, EventArgs e)
        {

        }
    }
}
