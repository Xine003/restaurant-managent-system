using System;
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
using Sitecore.FakeDb;

namespace restaurantSystem
{
    public partial class Products : Form
    {
        private DB db = new DB();
        public Products()
        {
            InitializeComponent();

            productsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            addProducts_btn.BackgroundImageLayout = ImageLayout.Stretch;


            LoadDataToDataGridView();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
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

        private void addProducts(object sender, MouseEventArgs e)
        {
            AddItems add_item = new AddItems();
            add_item.Show();
       }

        private void Products_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Red;
            deleteButtonColumn.UseColumnTextForButtonValue = true;



            dataGridView1.Columns.Add(deleteButtonColumn);

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

                    // Set the new data source
                    dataGridView1.DataSource = dataTable;

                    dataGridView1.ForeColor = Color.White;

                    dataGridView1.RowPrePaint += (sender, e) =>
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Transparent;
                    };

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



        private void deleteRow(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        db.openConnection();

                        string query = "DELETE FROM items WHERE id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                        {
                            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = productId;

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                dataGridView1.Rows.RemoveAt(e.RowIndex);
                                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Refresh the DataGridView to reflect changes
                                LoadDataToDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.closeConnection();
                    }
                }
            }
        }



       


    }
}
