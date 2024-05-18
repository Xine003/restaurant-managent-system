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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace restaurantSystem
{
    public partial class addEmployee : Form
    {
        private DB db = new DB();
        string uType = "Staff";

        public addEmployee()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            label6.Text = "  ";
            label6.Visible = false;
            

        }

        public void DisableButton1()
        {
            button1.Enabled = false;
        }

        public addEmployee(int userID, string firstName, string lastName, string emailAddress, string userName, string passWord)
        {
            InitializeComponent();
            id.Text = userID.ToString();
            fname.Text = firstName;
            lname.Text = lastName;
            emailAdd.Text = emailAddress;
            uname.Text = userName;
            pword.Text = passWord;
        }



        private void additem_btn_Click(object sender, EventArgs e)
        {

        }

        private void i_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureProduct_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUsersToDatabase(fname.Text, lname.Text, emailAdd.Text, uname.Text, pword.Text, uType);
        }


        //function to add user
        private void addUsersToDatabase(string firstName, string lastName, string emailAddress, string userName, string passWord, string userType)
        {
            string query = "INSERT INTO users (firstname, lastname, emailaddress, username, password, userType) VALUES (@FirstName, @LastName, @EmailAddress, @UserName, @Password, @UserType)";

            using (MySqlConnection connection = db.getConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", passWord);
                    command.Parameters.AddWithValue("@UserType", userType);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {

                            label6.Text = "User added successfully.";
                            label6.ForeColor = Color.Green;
                        }
                        else
                        {
                            label6.Text = "Error adding user.";
                            label6.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        label6.Text = "Error: " + ex.Message;
                    }
                }
            }
        }

        //updating
        private void updateUserInfoInDatabase(int id, string firstName, string lastName, string emailAddress, string userName, string passWord)
        {
            string query = "UPDATE users SET firstname = @FirstName, lastname = @LastName, emailaddress = @EmailAddress,username =@Username, password = @Password WHERE id = @Id";

            using (MySqlConnection connection = db.getConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", passWord);
                    command.Parameters.AddWithValue("@Id", id); // Pass the user ID as integer

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            label6.Text = "User information updated successfully.";
                            label6.ForeColor = Color.Green;
                        }
                        else
                        {
                            label6.Text = "Error updating user information.";
                            label6.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        label6.Text = "Error: " + ex.Message;
                        label6.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void removeUserFromDatabase(int id)
        {
            string query = "DELETE FROM users WHERE id = @Id";

            using (MySqlConnection connection = db.getConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id); 

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            label6.Text = "User deleted successfully.";
                            label6.ForeColor = Color.Green;
                        }
                        else
                        {
                            label6.Text = "Error deleting user.";
                            label6.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        label6.Text = "Error: " + ex.Message;
                        label6.ForeColor = Color.Red;
                    }
                }
            }
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(id.Text, out userId))
            {
               
                updateUserInfoInDatabase(userId, fname.Text, lname.Text, emailAdd.Text, uname.Text, pword.Text);
            }
            else
            {
               
                MessageBox.Show("Invalid user ID.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(id.Text, out userId))
            {
                removeUserFromDatabase(userId);
            }
            else
            {
                MessageBox.Show("Invalid user ID.");
            }
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
