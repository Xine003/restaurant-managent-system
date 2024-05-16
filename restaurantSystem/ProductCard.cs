using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using restaurantSystem.DesignCodes;

namespace restaurantSystem
{
    public partial class ProductCard : Form
    {
        public event EventHandler<string> ItemClicked;
        private DB db = new DB();

        public ProductCard()
        {
            InitializeComponent();
            DesignCodes.Borders.SetBorderRadius(imageHolder, 10);
            LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
        {
            try
            {
                // Open the database connection
                db.openConnection();

                // Define your query to select data from the "items" table
                string query = "SELECT name, price, productImage FROM items";

                // Create a MySqlCommand object to execute the query
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    // Execute the query and read the data
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any rows were returned
                        if (reader.Read())
                        {
                            // Load data into labels
                            productNameLabel.Text = reader["name"].ToString();
                            productPriceLabel.Text = reader["price"].ToString();

                            // Check if the productImage column is not null
                            if (!reader.IsDBNull(reader.GetOrdinal("productImage")))
                            {
                                // Read the image data as bytes
                                byte[] imageData = (byte[])reader["productImage"];

                                // Convert the bytes to an Image object
                                using (var ms = new System.IO.MemoryStream(imageData))
                                {
                                    imageHolder.Image = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            // No data returned from the query
                            MessageBox.Show("No data found in the items table.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                db.closeConnection();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxClicked(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, productNameLabel.Text);
        }
    }
}
