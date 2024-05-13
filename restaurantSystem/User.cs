
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
using restaurantSystem.DesignCodes;

namespace restaurantSystem
{
    

    public partial class User : Form
    { 
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=restaurant");
                private DB db = new DB();

        public User()
        {
            InitializeComponent();
            this.txtPassword.AutoSize = false;
            DesignCodes.Borders.SetBorderRadius(loginContainer, 20);
            DesignCodes.Borders.SetBorderRadius(txtUsername, 10);
            DesignCodes.Borders.SetBorderRadius(txtPassword, 10);
            DesignCodes.Borders.SetBorderRadius(btnLogin, 20);
            this.FormBorderStyle = FormBorderStyle.None;
            loginContainer.BackColor = Color.FromArgb(191, loginContainer.BackColor);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            panel2.BackColor = Color.Transparent;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Global.Gusername = username; // No need to convert to string again

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE username = @usn AND password = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // Check if the user exists or not
            if (table.Rows.Count > 0)
            {
                string userType = table.Rows[0]["userType"].ToString();

                switch (userType)
                {
                    case "Admin":
                        // Open the Main form for Admin users
                        this.Hide();
                        Main main = new Main();
                        main.Show();
                        break;
                    case "Staff":
                        // Open the Cashier form for Staff users
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void labelGoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
