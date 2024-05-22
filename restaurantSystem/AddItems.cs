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
using Sitecore.FakeDb;

namespace restaurantSystem
{
    public partial class AddItems : Form
    {
        private DB db = new DB();
        public AddItems()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.None;
            DesignCodes.Borders.SetBorderRadius(additem_btn,30);
            DesignCodes.Borders.SetBorderRadius(back_btn, 30);

            LoadCategories();

            this.FormBorderStyle= FormBorderStyle.None;
        }






        private Products productsForm;

        public AddItems(Products productsForm)
        {
            InitializeComponent();
            this.productsForm = productsForm; 
        }

        public void DisableButton1()
        {
            additem_btn.Enabled = false;
        }

        public AddItems(int userId, string name, int price, string category, Bitmap imageData)
        {
            InitializeComponent();

            labelUserID.Text = userId.ToString();
            i_name.Text = name;
            i_price.Text = price.ToString();

            LoadCategories();

            SetSelectedCategory(category);

            if (imageData != null)
            {
                pictureProduct.Image = imageData;
            }
        }

        private void LoadCategories()
        {
            try
            {

                i_category.Items.Clear();

                i_category.Items.Add("Choose Category");
                i_category.Items.Add("Main Course");
                i_category.Items.Add("Appetizer");
                i_category.Items.Add("Desserts");
                i_category.Items.Add("Beverages");
                i_category.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void SetSelectedCategory(string category)
        {
            int index = i_category.FindStringExact(category);

        
            if (index != -1)
            {
                i_category.SelectedIndex = index;
            }
        }




        private void back_btn_Click(object sender, EventArgs e)
        {
            UpdateProduct();
           
            this.Close();


        }

        private void additem_btn_Click(object sender, EventArgs e)
        {

            try
            {
              
                byte[] imageData = ImageToByteArray(pictureProduct.Image);

                
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    string query = "INSERT INTO items (name, price, category, productImage) VALUES (@name, @price, @category, @image)";

                   
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@name", i_name.Text);
                        command.Parameters.AddWithValue("@price", i_price.Text);
                        command.Parameters.AddWithValue("@category", i_category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@image", imageData);

                     
                        command.ExecuteNonQuery();

                      
                        MessageBox.Show("Item added successfully!");
                       
                        pictureProduct.Image = null;
                        i_category.Text = "";
                        i_price.Text = "";
                       
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error adding item: " + ex.Message);
            }
            this.Close();

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


      


        private void chooseImage(object sender, MouseEventArgs e)

        {
          
            OpenFileDialog openFileDialog = new OpenFileDialog();

         
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

          
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                 
                    string imagePath = openFileDialog.FileName;

                  
                    pictureProduct.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }

        }

        private void i_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void UpdateProduct()
        {
           
            if (string.IsNullOrWhiteSpace(i_name.Text) || string.IsNullOrWhiteSpace(i_price.Text) || i_category.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
              
                int productId = Convert.ToInt32(labelUserID.Text);

             
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    string query = "UPDATE items SET name = @name, price = @price, category = @category WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", i_name.Text);
                        command.Parameters.AddWithValue("@price", i_price.Text);
                        command.Parameters.AddWithValue("@category", i_category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@id", productId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateImage()
        {
            try
            {
                // Get the ID of the product
                int productId = Convert.ToInt32(labelUserID.Text);

                // Convert the new image to byte array
                byte[] newImageData = null;
                if (pictureProduct.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureProduct.Image.Save(ms, pictureProduct.Image.RawFormat);
                        newImageData = ms.ToArray();
                    }
                }

                // Update only the image column in the database
                if (newImageData != null)
                {
                    using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                    {
                        connection.Open();

                        string query = "UPDATE items SET productImage = @image WHERE id = @id";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@image", newImageData);
                            command.Parameters.AddWithValue("@id", productId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product image updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to update product image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No new image selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Ensure that labelUserID contains a valid integer ID
                if (int.TryParse(labelUserID.Text, out int userId))
                {
                    db.openConnection();

                    string query = "DELETE FROM items WHERE id = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@ID", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
