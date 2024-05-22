﻿using MySql.Data.MySqlClient;
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

namespace restaurantSystem
{
    public partial class AddCoupon : Form
    {
        public event Action CouponAdded;

        private DB db = new DB();

        public AddCoupon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string randomString = new string(Enumerable.Repeat(chars, 6)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // Set the generated string in the discCode TextBox
            discText.Text = randomString;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve discount details from form controls
                string discountCode = discText.Text;
                if (string.IsNullOrWhiteSpace(discountCode))
                {
                    MessageBox.Show("Discount code cannot be empty.");
                    return;
                }

                if (!decimal.TryParse(percent.Text, out decimal discountValue) || discountValue <= 0 || discountValue > 100)
                {
                    MessageBox.Show("Invalid discount value. Please enter a valid number for the discount percent (between 1 and 100).");
                    return;
                }

                DateTime createdDate = DateTime.Now;
                DateTime validDate = exp.Value; // Get the selected date from the DateTimePicker control
                if (validDate <= createdDate)
                {
                    MessageBox.Show("Expiration date must be later than the current date.");
                    return;
                }

                if (!int.TryParse(lim.Text, out int limit) || limit <= 0)
                {
                    MessageBox.Show("Invalid limit value. Please enter a valid number for the limit.");
                    return;
                }

                // Insert discount details into the database
                string query = "INSERT INTO discount (disc_code, disc_value, date_created, date_valid, `limit`) " +
                               "VALUES (@Code, @Value, @CreatedDate, @ValidDate, @Limit)";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.AddWithValue("@Code", discountCode);
                command.Parameters.AddWithValue("@Value", discountValue);
                command.Parameters.AddWithValue("@CreatedDate", createdDate);
                command.Parameters.AddWithValue("@ValidDate", validDate);
                command.Parameters.AddWithValue("@Limit", limit);

                db.openConnection();
                int rowsAffected = command.ExecuteNonQuery();
                db.closeConnection();

                MessageBox.Show(rowsAffected + " discount added successfully.");

                discText.Text = "";
                lim.Text = "";
                percent.Text = "";
                CouponAdded?.Invoke();
                this.Close();
            }
            catch (FormatException ex)
            {
                // Handle format exception (e.g., parsing errors)
                MessageBox.Show("Input format error: " + ex.Message);
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-related exceptions
                MessageBox.Show($"MySQL error: {ex.Message}\nError Code: {ex.Number}\nStack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"General error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }

        }
    }
}
