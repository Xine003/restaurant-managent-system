using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
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
    public partial class NewOrder : Form
    {
        private DB db = new DB();
        ordersCard orderCard;
        public NewOrder()
        {
            InitializeComponent();
            PopulateFlowLayout();
            flowLayoutPanel.AutoScroll = true;

          



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

        private void PopulateFlowLayout(string category = null)
        {
            flowLayoutPanel.Controls.Clear();

            try
            {
                db.openConnection();

                string query = "SELECT name, price, productImage FROM items";
                if (!string.IsNullOrEmpty(category))
                {
                    query += " WHERE category = @category";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    if (!string.IsNullOrEmpty(category))
                    {
                        cmd.Parameters.AddWithValue("@category", category);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ControlProductCard controlProductCard = new ControlProductCard();
                            controlProductCard.Margin = new Padding(10);

                            controlProductCard.LoadDataFromDatabase(reader["name"].ToString(), reader["price"].ToString());

                            if (!reader.IsDBNull(reader.GetOrdinal("productImage")))
                            {
                                byte[] imageData = (byte[])reader["productImage"];

                                using (var ms = new System.IO.MemoryStream(imageData))
                                {
                                    controlProductCard.LoadImageFromDatabase(Image.FromStream(ms));
                                }
                            }

                            flowLayoutPanel.Controls.Add(controlProductCard);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
              
                db.closeConnection();
            }
        }





        private void mainCourse_Click(object sender, EventArgs e)
        {
            PopulateFlowLayout("Main Course");
        }

      
        private void appetizer_Click(object sender, EventArgs e)
        {
            PopulateFlowLayout("Appetizer");
        }

     
        private void dessert_Click(object sender, EventArgs e)
        {
            PopulateFlowLayout("Desserts");
        }

       
        private void beverages_Click(object sender, EventArgs e)
        {
            PopulateFlowLayout("Beverages");
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void addUserControl(ControlProductCard controlProductCard) { 
            flowLayoutPanel.Controls.Add(controlProductCard);
          
        
        }


       

        private void ControlProductCard_Clicked(object sender, EventArgs e)
        {
            // Cast the sender object to ControlProductCard to access its properties
            ControlProductCard controlProductCard = (ControlProductCard)sender;

            // Get the product name from the clicked control
            string productName = controlProductCard.ProductName;

            // Add the product name to the DataGridView
            dataGridView1.Rows.Add(productName);

            // Refresh the DataGridView to reflect the changes
            dataGridView1.Refresh();
        }




    }
}
