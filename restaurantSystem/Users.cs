using System.Data;
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

            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Users_Load(object sender, EventArgs e)
        {
           employee_Table.DataSource = userlist();
        }

        private DataTable userlist() {


            DB db = new DB();

           
            DataTable table = new DataTable();

            

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());


            db.openConnection();


             MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }

        private void user_table_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUsers addUsers = new AddUsers();
            addUsers.Show();
        }

        private void removeuser_btn_Click(object sender, EventArgs e)
        {
            string idLocRemv = employee_Table.SelectedRows[0].Cells[0].Value.ToString();




       

           // string removeVolCred = "DELETE FROM user WHERE id = " + idLocRemv;

           

            DB db = new DB();
            DataTable table = new DataTable();


            db.openConnection();


            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id = " + idLocRemv, db.getConnection());


        


            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            this.Hide();
            Users users = new Users();
            users.Show();

            MessageBox.Show("Row with ID "+idLocRemv+ "  got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void employeeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
