﻿using MySql.Data.MySqlClient;
using restaurantSystem.DesignCodes;
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
    public partial class Coupons : Form
    {
        public Coupons()
        {
            InitializeComponent();
            DisplayDiscounts(couponPanel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddCoupon addDiscountsForm = new AddCoupon();
            addDiscountsForm.FormBorderStyle = FormBorderStyle.None;
            addDiscountsForm.CouponAdded += AddDiscountsForm_CouponAdded;

            addDiscountsForm.Show();
        }

        private void AddDiscountsForm_CouponAdded()
        {
           
            DisplayDiscounts(couponPanel);
        }


        private void DisplayDiscounts(FlowLayoutPanel couponPanel)
        {
            couponPanel.Controls.Clear(); 
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<DiscountData> discounts = dbHelper.GetDiscountData(); 

            foreach (var discount in discounts)
            {
                Panel discountPanel = new Panel
                {
                    Width = 400,
                    Height = 150,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = Color.White,
                    BackgroundImage = Properties.Resources.coups,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
              
                Borders.SetBorderRadius(discountPanel, 20);

                Font labelFont = new Font("Helvetica", 9, FontStyle.Regular);

                Label codeLabel = new Label
                {
                    Text = discount.Code,
                    AutoSize = true,
                   
                    Location = new Point(15, 60), 
                    Font = new Font("Impact", 30, labelFont.Style),
                    BackColor = Color.Transparent,
                    
                };

                Label valueLabel = new Label
                {
                    Text = "" + discount.Value + "%",
                    AutoSize = true,
               
                    Location = new Point(265, 15),
                    Font = new Font("Impact", 25, labelFont.Style),
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                   
                };

                Label validLabel = new Label
                {
                    Text = "Valid until: " + discount.ValidUntil.ToString("yyyy-MM-dd"),
                    AutoSize = true,
                 
                    Location = new Point(20, 110),
                    Font = new Font("Inter", 10),
                    BackColor = Color.Transparent,
                    
                };

                // Create a panel below the total amount label


                discountPanel.Controls.Add(codeLabel);
                discountPanel.Controls.Add(valueLabel);
              
                discountPanel.Controls.Add(validLabel);
               

                couponPanel.Controls.Add(discountPanel);
            }
        }


        private class DatabaseHelper
        {
            private string connectionString = "server=localhost;port=3306;username=root;password=;database=restaurant";

            public List<DiscountData> GetDiscountData()
            {
                List<DiscountData> discounts = new List<DiscountData>();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM discount WHERE `limit` > 0";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DiscountData discount = new DiscountData()
                                {
                                   
                                    Code = reader["disc_code"].ToString(),
                                    Value = Convert.ToDouble(reader["disc_value"]),
                                    ValidUntil = Convert.ToDateTime(reader["date_valid"]),
                                   
                                };
                                discounts.Add(discount);
                            }
                        }
                    }
                }

                return discounts;
            }
        }

        public class DiscountData
        {
            public int ID { get; set; }
            public string Code { get; set; }
            public double Value { get; set; }
            public DateTime Created { get; set; }
            public DateTime ValidUntil { get; set; }
            public int Limit { get; set; }
        }


    }
}
