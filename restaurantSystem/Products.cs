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
using MySql.Data.MySqlClient;
using restaurantSystem.DesignCodes;
using Sitecore.FakeDb;


namespace restaurantSystem
{
    public partial class Products : Form
    {
        private Products productsForm;
        private DB db = new DB();
        private Panel dashboardPanel;
        public Products()
        {
            InitializeComponent();

            productsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            addProducts_btn.BackgroundImageLayout = ImageLayout.Stretch;


            LoadDataToDataGridView();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }

        private void addProducts(object sender, MouseEventArgs e)
        {
            AddItems add_item = new AddItems();
            add_item.Show();
        }




        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addProducts_btn_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void Products_Load(object sender, EventArgs e)
        {
          
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                dataGridView1.DataSource = null;

                db.openConnection();

                string query = "SELECT id, name AS productName, category AS productCategory, price AS productPrice FROM items";

                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.ForeColor = Color.White;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void tableclicked(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               
            }
            else if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                int userId = Convert.ToInt32(row.Cells["id"].Value);
                string name = row.Cells["productName"].Value.ToString();
                string category = row.Cells["productCategory"].Value.ToString();
                int price = Convert.ToInt32(row.Cells["productPrice"].Value);

                Bitmap imageData = null;

                try
                {
                    int productId = Convert.ToInt32(row.Cells["id"].Value);

                    using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=restaurant"))
                    {
                        connection.Open();

                        string query = "SELECT productImage FROM items WHERE id = @id";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", productId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("productImage")))
                                {
                                    byte[] imageBytes = (byte[])reader["productImage"];
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        imageData = new Bitmap(ms);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product image: " + ex.Message);
                    return;
                }

                AddItems addItemsForm = new AddItems(userId, name, price, category, imageData);
                addItemsForm.Show();
                addItemsForm.DisableButton1();
            }
        }




        private void deleteRow(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }



       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


       


        private void label2_Click(object sender, EventArgs e)

        {

            ClearDataGridView();
            LoadDataToDataGridView();

        }

        private void ClearDataGridView()
        {
            // Clear the data source
            dataGridView1.DataSource = null;

            // Clear any existing rows and columns
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Clear any data bindings
            dataGridView1.DataBindings.Clear();

            // Force a visual refresh
            dataGridView1.Refresh();
        }

        private void LoadDataToDataGridViewRefresh()
        {
            

            try
            {

                db.openConnection();

                string query = "SELECT id, name AS productName, category AS productCategory, price AS productPrice FROM items";

                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.ForeColor = Color.White;

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

    }
}
