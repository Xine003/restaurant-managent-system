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
using System.Drawing.Drawing2D;

namespace restaurantSystem
{
   
    public partial class AddItems : Form
    {

        public delegate void ItemAddedEventHandler();
  
        public event ItemAddedEventHandler ItemAdded;
        private bool imageChanged = false;
        private Image previousImage;
        private DB db = new DB();
        public AddItems()
        {
            InitializeComponent();
          
            this.FormBorderStyle = FormBorderStyle.None;
            DesignCodes.Borders.SetBorderRadius(additem_btn,30);
            DesignCodes.Borders.SetBorderRadius(back_btn, 30);
            DesignCodes.Borders.SetBorderRadius(panel1, 20);
            LoadCategories();

            this.FormBorderStyle= FormBorderStyle.None;
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

          
            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 70; 

                path.AddArc(0, 0, radius, radius, 180, 90); 
                path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); 
                path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); 
                path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

               
                this.Region = new Region(path);
            }
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

        string previousPath;

        public AddItems(int userId, string name, int price, string category, Bitmap imageData, string filePath)
        {
            InitializeComponent();

            labelUserID.Text = userId.ToString();
            i_name.Text = name;
            i_price.Text = price.ToString();

            LoadCategories();

            SetSelectedCategory(category);

            pictureProduct.Image = imageData;
            richTextBox1.Text = filePath;
            previousPath = filePath;
            
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
            if (imageChanged) {
                UpdateProduct();
                OnItemAdded();
                i_name.Text = "";
                pictureProduct.Image = null;
                i_category.SelectedIndex = 0;
                i_price.Text = "";
                richTextBox1.Text = "";
            }
            else 
            {
                
                UpdateProductWithoutImage();
                OnItemAdded();
                i_name.Text = "";
                pictureProduct.Image = null;
                i_category.SelectedIndex   = 0;
                i_price.Text = "";
                richTextBox1.Text = "";
            }

        }

        private void additem_btn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(i_name.Text) || string.IsNullOrWhiteSpace(i_price.Text) || i_category.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill in all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
              
                byte[] imageData = ImageToByteArray(pictureProduct.Image);
                string path = richTextBox1.Text;
                
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    string query = "INSERT INTO items (name, price, category, productImage, imagePath) VALUES (@name, @price, @category, @image, @path)";

                   
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@name", i_name.Text);
                        command.Parameters.AddWithValue("@price", i_price.Text);
                        command.Parameters.AddWithValue("@category", i_category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@image", imageData);
                        command.Parameters.AddWithValue("@path", path);

                        command.ExecuteNonQuery();

                       
                        MessageBox.Show("Item added successfully!");

                        OnItemAdded();

                        i_name.Text = "";
                        pictureProduct.Image = null;
                        i_category.SelectedIndex = 0;
                        i_price.Text = "";
                        richTextBox1.Text = "";
                       
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error adding item: " + ex.Message);
            }
            this.Close();

           
        }

        protected virtual void OnItemAdded()
        {
            ItemAdded?.Invoke();
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

                    richTextBox1.Text = imagePath;
                    imageChanged = true;
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
                byte[] imageBytes = null;

                // Convert image in pictureProduct to byte array if there is an image
                if (pictureProduct.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureProduct.Image.Save(ms, pictureProduct.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                {
                    connection.Open();

                    string query = "UPDATE items SET name = @name, price = @price, category = @category, productImage = @productImage WHERE id = @id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", i_name.Text);
                        command.Parameters.AddWithValue("@price", i_price.Text);
                        command.Parameters.AddWithValue("@category", i_category.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@id", productId);
                        command.Parameters.AddWithValue("@productImage", imageBytes ?? (object)DBNull.Value); // Handle null image

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



        private void UpdateProductWithoutImage()
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
                            OnItemAdded();
                            i_name.Text = "";
                            pictureProduct.Image = null;
                            i_category.SelectedIndex = 0;
                            i_price.Text = "";
                            richTextBox1.Text = "";
                            

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
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void AddItems_Load(object sender, EventArgs e)
        {

        }
    }
}
