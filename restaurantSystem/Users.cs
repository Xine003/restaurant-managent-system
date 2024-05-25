using System.Data;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sitecore.FakeDb;

namespace restaurantSystem
{
    public partial class Users : Form
    {


        private DB db = new DB();
        public Users()
        {
            InitializeComponent();
            employee_Table.BackgroundColor = System.Drawing.Color.FromArgb(17, 19, 21);


        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Users_Load(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        public void RefreshUserData()
        {
            ClearDataGridView();
            LoadDataToDataGridView();
        }

        private void ClearDataGridView()
        {

            employee_Table.DataSource = null;


           employee_Table.Rows.Clear();
            employee_Table.Columns.Clear();
            employee_Table.DataBindings.Clear();
            employee_Table.Refresh();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                employee_Table.DataSource = null;

                db.openConnection();

                string query = "SELECT * FROM users";

                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    DataTable dataTable = new DataTable();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    employee_Table.DataSource = dataTable;
                    employee_Table.ForeColor = System.Drawing.Color.White;

                    foreach (DataGridViewColumn column in employee_Table.Columns)
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

        private void user_table_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
           
        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            AddUsers addUsers = new AddUsers();
            addUsers.Show();
        }

        private void removeuser_btn_Click(object sender, EventArgs e)
        {
            if (employee_Table.SelectedRows.Count > 0)
            {
                string idLocRemv = employee_Table.SelectedRows[0].Cells[0].Value.ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id = @Id", db.getConnection());
                command.Parameters.AddWithValue("@Id", idLocRemv);
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Row with ID " + idLocRemv + " got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUserData(); 
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void employee_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProducts_btn_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void addUser(object sender, MouseEventArgs e)
        {
            addEmployee addEmployeeForm = new addEmployee(this);
            addEmployeeForm.DisableButton12();
            addEmployeeForm.Show();
        }

        private void employee_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employee_Table.Rows[e.RowIndex];
                int userId = Convert.ToInt32(row.Cells["id"].Value); // Assuming the ID column name is "id"
                string firstName = row.Cells["firstname"].Value.ToString();
                string lastName = row.Cells["lastname"].Value.ToString();
                string emailAddress = row.Cells["emailaddress"].Value.ToString();
                string userName = row.Cells["username"].Value.ToString();
                string passWord = row.Cells["password"].Value.ToString();

                addEmployee addEmployeeForm = new addEmployee(userId, firstName, lastName, emailAddress, userName, passWord, this);
                addEmployeeForm.Show();
                addEmployeeForm.FormBorderStyle = FormBorderStyle.None;
                addEmployeeForm.DisableButton1();
            }
        }
    }
}
