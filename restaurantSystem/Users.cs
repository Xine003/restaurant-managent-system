﻿using System.Data;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurantSystem
{
    public partial class Users : Form
    {



        public Users()
        {
            InitializeComponent();
            employee_Table.BackgroundColor = System.Drawing.Color.FromArgb(17, 19, 21);

           



        }




        private void back_btn_Click(object sender, EventArgs e)
        {
            // Handle back button click event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event
        }

        private void Users_Load(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        public void RefreshUserData()
        {
            employee_Table.DataSource = userlist();
            foreach (DataGridViewColumn column in employee_Table.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private DataTable userlist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());
            db.openConnection();
            MySqlDataReader rdr = command.ExecuteReader();
            table.Load(rdr);
            db.closeConnection();
            return table;
        }

        private void user_table_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            // Handle allow user to add rows changed event
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
                RefreshUserData(); // Refresh data after deletion
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle employee table cell content click event
        }

        private void employee_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle employee table cell content click event
        }

        private void addProducts_btn_Paint(object sender, PaintEventArgs e)
        {
            // Handle add products button paint event
        }

        private void addUser(object sender, MouseEventArgs e)
        {
            addEmployee addEmployeeForm = new addEmployee(this);
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
                addEmployeeForm.DisableButton1();
            }
        }
    }
}
