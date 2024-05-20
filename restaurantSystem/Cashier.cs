using MySql.Data.MySqlClient;
using Renci.SshNet.Common;
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
    public partial class Cashier : Form
    {
        private Timer timer;
        private comboBox1 newOrderForm;
        private Receipt newRecieptForm;
        private Table newtableForm;

      
        public Cashier()
        {
            InitializeComponent();
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            home_btn.FlatAppearance.BorderSize = 0;
            tableReservation_btn.FlatAppearance.BorderSize = 0;
            orderList_btn.FlatAppearance.BorderSize = 0;
            logOut_btn.FlatAppearance.BorderSize = 0;
            LoadNewOrderForm();

            timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();

            DateTimeLabel();

            this.FormBorderStyle = FormBorderStyle.None;


        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void pos_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pos pos = new Pos();
            pos.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                if (dbHelper.HasPendingOrders())
                {
                    MessageBox.Show("There are still pending orders that need to be paid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User user = new User();
                    user.Show();
                    this.Hide();
                }
            }

        }



        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //functions
        private void LoadNewOrderForm()
        {
            // Initialize the dashboard form
            newOrderForm = new comboBox1();
            newOrderForm.TopLevel = false;
            newOrderForm.FormBorderStyle = FormBorderStyle.None;
            newOrderForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newOrderForm);
            newOrderForm.Show();

        }

        private void LoadRecieptForm()
        {
            // Initialize the dashboard form
            newRecieptForm = new Receipt();
            newRecieptForm.TopLevel = false;
            newRecieptForm.FormBorderStyle = FormBorderStyle.None;
            newRecieptForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newRecieptForm);
            newRecieptForm.Show();


        }

        private void LoadTableForm()
        {
            // Initialize the dashboard form
            newtableForm = new Table();
            newtableForm.TopLevel = false;
            newtableForm.FormBorderStyle = FormBorderStyle.None;
            newtableForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newtableForm);
            newtableForm.Show();


        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            LoadNewOrderForm();
            label6.Text = "New Order";
        }

        private void orderList_btn_Click(object sender, EventArgs e)
        {
            LoadRecieptForm();
            label6.Text = "Payment";
        }

        private void tableReservation_btn_Click(object sender, EventArgs e)
        {
            LoadTableForm();
            label6.Text = "Table Reservation";
        }

        // functions 
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTimeLabel();
        }

        private void DateTimeLabel()
        {
            DateTime currentDateTime = DateTime.Now;
            dateTime_label.Text = $"{currentDateTime.ToString("dddd, MMMM dd, yyyy - hh:mm:ss tt")}";
        }


        private bool HasPendingOrders()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<OrderData> orders = dbHelper.GetOrderData();
            return orders.Any(order => !order.IsPaid);
        }

        private void home_btn_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void tableReservation_btn_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void orderList_btn_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void logOut_btn_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public class DatabaseHelper
        {
            private string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";

            public bool HasPendingOrders()
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM ordertable WHERE isPaid = 0";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                    }
                }
            }

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
                                    OrderQuantity = Convert.ToInt32(reader["orderQuantity"]),
                                    IsPaid = Convert.ToBoolean(reader["isPaid"])
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
                                    IsPaid = Convert.ToBoolean(reader["isPaid"])
                                };
                                orders.Add(order);
                            }
                        }
                    }
                }

                return orders;
            }

            public void InsertHistoryTransaction(OrderData order, double cashTendered, double changeAmount)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO historyTransaction (orderID, ORNumber, orderName, perPrice, orderQuantity, tableNumber, totalAmount, date, time, cashTendered, changeAmount) " +
                                 "VALUES (@OrderID, @ORNumber, @OrderName, @PerPrice, @OrderQuantity, @TableNumber, @TotalAmount, @Date, @Time, @CashTendered, @ChangeAmount)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
                        cmd.Parameters.AddWithValue("@ORNumber", order.ORNumber);
                        cmd.Parameters.AddWithValue("@OrderName", order.OrderName);
                        cmd.Parameters.AddWithValue("@PerPrice", order.PerPrice);
                        cmd.Parameters.AddWithValue("@OrderQuantity", order.OrderQuantity);
                        cmd.Parameters.AddWithValue("@TableNumber", order.TableNumber);
                        cmd.Parameters.AddWithValue("@TotalAmount", order.TotalAmount);
                        cmd.Parameters.AddWithValue("@Date", order.Date);
                        cmd.Parameters.AddWithValue("@Time", order.Time);
                        cmd.Parameters.AddWithValue("@CashTendered", cashTendered);
                        cmd.Parameters.AddWithValue("@ChangeAmount", changeAmount);

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
        }

        public class OrderData
        {
            public int OrderID { get; set; }
            public string ORNumber { get; internal set; }
            public object Time { get; internal set; }
            public object Date { get; internal set; }
            public object TotalAmount { get; internal set; }
            public object TableNumber { get; internal set; }
            public object OrderQuantity { get; internal set; }
            public object PerPrice { get; internal set; }
            public object OrderName { get; internal set; }
            public bool IsPaid { get; internal set; }
        }
    }
}
