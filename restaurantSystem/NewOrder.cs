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

        private void PopulateFlowLayout()
        {
            
            flowLayoutPanel.Controls.Clear();

            try
            {
              
                db.openConnection();

               
                string query = "SELECT name, price, productImage FROM items";

               
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                   
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
                // Close the database connection
                db.closeConnection();
            }
        }


    }
}
