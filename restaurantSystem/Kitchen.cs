using MySql.Data.MySqlClient;
using restaurantSystem.DesignCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace restaurantSystem
{
    public partial class Kitchen : Form
    {
        public Kitchen()
        {
            InitializeComponent();
            DisplayOrders(orderPanel);
        }

        private void DisplayOrders(FlowLayoutPanel orderPanel)
        {
            orderPanel.Controls.Clear();
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<OrderData> orders = dbHelper.GetOrderData(); // Fetching order data from ongoingorders

            // Group orders by ORNumber and tableNumber
            var groupedOrders = orders
                .GroupBy(o => new { o.ORNumber, o.TableNumber })
                .Select(g => new
                {
                    ORNumber = g.Key.ORNumber,
                    TableNumber = g.Key.TableNumber,
                    Products = g.Select(o => new { o.OrderName, o.OrderQuantity }).ToList()
                }).ToList();

            foreach (var orderGroup in groupedOrders)
            {
                Panel orderPanelItem = new Panel
                {
                    Width = 400,
                    Height = 450, // Adjusted height to fit the order information and button
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = Color.Transparent,
                    BackgroundImage = Properties.Resources.Group_195,
                    BackgroundImageLayout = ImageLayout.Stretch
                };

                Borders.SetBorderRadius(orderPanelItem, 20);

                Font labelFont = new Font("Inter", 9, FontStyle.Regular);

                Label orNumberLabel = new Label
                {
                    Text = "Order Number: " + orderGroup.ORNumber,
                    AutoSize = true,
                    Location = new Point(15, 70),
                    Font = new Font("Inter", 14, labelFont.Style),
                    BackColor = Color.Transparent
                };

                Label tableNumberLabel = new Label
                {
                    Text = "Table Number: " + orderGroup.TableNumber,
                    AutoSize = true,
                    Location = new Point(15, 100),
                    Font = new Font("Inter", 14, labelFont.Style),
                    BackColor = Color.Transparent
                };

                Panel flowLayoutWrapperPanel = new Panel
                {
                    Width = 370,
                    Height = 270,
                    Location = new Point(15, 130),
                    BackColor = Color.Transparent,
                    BorderStyle = BorderStyle.FixedSingle
                };

                FlowLayoutPanel productFlowLayoutPanel = new FlowLayoutPanel
                {
                    Width = 360, 
                    Height = 280, 
                    AutoScroll = true,
                    BackColor = Color.Transparent,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false 
                };

                foreach (var product in orderGroup.Products)
                {
                    Label productLabel = new Label
                    {
                        Text = $"{product.OrderName} - Quantity: {product.OrderQuantity}",
                        AutoSize = true,
                        Width = productFlowLayoutPanel.Width - 10, 
                        Font = new Font("Inter", 12, labelFont.Style),
                        BackColor = Color.Transparent,
                        Margin = new Padding(5)
                    };

                    productFlowLayoutPanel.Controls.Add(productLabel);
                }

                flowLayoutWrapperPanel.Controls.Add(productFlowLayoutPanel);

                Button orderCompleteButton = new Button
                {
                    Text = "Order Complete",
                    Width = 150,
                    Height = 30,
                    Location = new Point(125, 410), 
                    BackColor = Color.Green,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.White,
                    Font = new Font("Inter", 12, FontStyle.Regular),
                    Tag = orderGroup.ORNumber 
                };
                orderCompleteButton.FlatAppearance.BorderSize = 0;
                orderCompleteButton.Click += OrderCompleteButton_Click;

                orderPanelItem.Controls.Add(orNumberLabel);
                orderPanelItem.Controls.Add(tableNumberLabel);
                orderPanelItem.Controls.Add(flowLayoutWrapperPanel);
                orderPanelItem.Controls.Add(orderCompleteButton);

                orderPanel.Controls.Add(orderPanelItem);
            }
        }

        private void OrderCompleteButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string orNumber = button.Tag as string;
                if (!string.IsNullOrEmpty(orNumber))
                {
                    DeleteOrder(orNumber);
                    DisplayOrders(orderPanel);
                }
            }
        }

        private void DeleteOrder(string orNumber)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.DeleteOrderData(orNumber);
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
                    string sql = "SELECT * FROM ongoingorders";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderData order = new OrderData()
                                {
                                    ORNumber = reader["ORNumber"].ToString(),
                                    OrderName = reader["orderName"].ToString(),
                                    OrderQuantity = Convert.ToInt32(reader["orderQuantity"]),
                                    TableNumber = Convert.ToInt32(reader["tableNumber"])
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }

                return orders;
            }

            public void DeleteOrderData(string orNumber)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM ongoingorders WHERE ORNumber = @ORNumber";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ORNumber", orNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public class OrderData
        {
            public string ORNumber { get; set; }
            public string OrderName { get; set; }
            public int OrderQuantity { get; set; }
            public int TableNumber { get; set; }
        }

    }
}
