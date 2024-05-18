using MySql.Data.MySqlClient;
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
  
    public partial class Table : Form
    {
        private Label[] tableLabels;
        private List<Button> tableButtons;
        public Table()
        {
            InitializeComponent();
            tableLabels = new Label[] { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 };
            tableButtons = this.Controls.OfType<Button>()
                                          .Where(btn => btn.Name.StartsWith("table") && btn.Name.EndsWith("btn"))
                                          .ToList();
            CheckAndUpdateTableStatuses();
        }

        private void CheckAndUpdateTableStatuses()
        {
            // Connect to the database and retrieve table numbers
            string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";
            string sql = "SELECT tableNumber FROM ordertable";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableNumber = reader["tableNumber"].ToString();

                            // Search for a matching label and update its properties
                            foreach (Label label in tableLabels)
                            {
                                if (label.Name.ToLower() == "t" + tableNumber.ToLower())
                                {
                                    label.Text = "Reserved";
                                    label.BackColor = Color.LightSalmon; // Change the color to LightRed
                                    break; // Exit the loop once a match is found
                                }
                            }

                            foreach (Button button in tableButtons)
                            {
                                if (button.Name.ToLower() == "table" + tableNumber.ToLower() + "btn")
                                {
                                    button.Enabled = false;
                                    break; // Exit the loop once a match is found
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
