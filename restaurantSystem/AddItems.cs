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
using restaurantSystem.DesignCodes;
using System.Drawing.Imaging;
using System.IO;

namespace restaurantSystem
{
    public partial class AddItems : Form
    {
        private DB DB = new DB();
        public AddItems()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.None;
            DesignCodes.Borders.SetBorderRadius(additem_btn,30);
            DesignCodes.Borders.SetBorderRadius(back_btn, 30);

            LoadCategories();

        }


        private Products productsForm;
        public AddItems(Products productsForm)
        {
            InitializeComponent();
            this.productsForm = productsForm; 
        }



        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the image data from the PictureBox
                byte[] imageData = ImageToByteArray(pictureProduct.Image);

                // Open the database connection
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    // Define the INSERT statement with parameters to prevent SQL injection
                    string query = "INSERT INTO items (name, price, category, productImage) VALUES (@name, @price, @category, @image)";

                    // Create a MySqlCommand object with the INSERT statement and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@name", i_name.Text);
                        command.Parameters.AddWithValue("@price", i_price.Text);
                        command.Parameters.AddWithValue("@category", i_category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@image", imageData);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Inform the user that the item has been added successfully
                        MessageBox.Show("Item added successfully!");

                        pictureProduct.Image = null;
                        i_category.Text = "";
                        i_price.Text = "";
                       
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations
                MessageBox.Show("Error adding item: " + ex.Message);
            }


        }

        private void i_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bgpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

         }


        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void LoadCategories()
        {
            try
            {
                // Open a connection to the database
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    // Define the query to select categories from the database
                    string query = "SELECT category FROM category";

                    // Create a command object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Execute the query and read the results
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the ComboBox
                            i_category.Items.Clear();

                            // Loop through the results and add each category to the ComboBox
                            while (reader.Read())
                            {
                                i_category.Items.Add(reader["category"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }


        private void chooseImage(object sender, MouseEventArgs e)

        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter for image files
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected file name
                    string imagePath = openFileDialog.FileName;

                    // Load the selected image into the PictureBox
                    pictureProduct.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur while loading the image
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

           

        }



    }
}
