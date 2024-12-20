﻿using System;
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
    public partial class Cashier : Form

    {
        private Timer timer;
        private comboBox1 newOrderForm;
        private Receipt newRecieptForm;
        private Table newtableForm;
        private Kitchen newKitchenForm;
        public Cashier()
        {
            InitializeComponent();
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            home_btn.FlatAppearance.BorderSize = 0;
            tableReservation_btn.FlatAppearance.BorderSize = 0;
            orderList_btn.FlatAppearance.BorderSize = 0;
            logOut_btn.FlatAppearance.BorderSize = 0;
            LoadNewOrderForm();

            timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();

            DateTimeLabel();

            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void pos_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pos pos = new Pos();
            pos.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Cashier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                User user = new User();
                user.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //functions
        private void LoadNewOrderForm()
        {
            
            newOrderForm = new comboBox1();
            newOrderForm.TopLevel = false;
            newOrderForm.FormBorderStyle = FormBorderStyle.None;
            newOrderForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newOrderForm);
            newOrderForm.Show();
        }


        private void LoadRecieptForm()
        
        {
           
            newRecieptForm = new Receipt();
            newRecieptForm.TopLevel = false;
            newRecieptForm.FormBorderStyle = FormBorderStyle.None;
            newRecieptForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newRecieptForm);
            newRecieptForm.Show();
        }
        
        private void LoadTableForm()
        {
            
            newtableForm = new Table();
            newtableForm.TopLevel = false;
            newtableForm.FormBorderStyle = FormBorderStyle.None;
            newtableForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newtableForm);
            newtableForm.Show();
        }

        private void LoadKitchenForm()
        {

            newKitchenForm = new Kitchen();
            newKitchenForm.TopLevel = false;
            newKitchenForm.FormBorderStyle = FormBorderStyle.None;
            newKitchenForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newKitchenForm);
            newKitchenForm.Show();
        }



        private void home_btn_Click(object sender, EventArgs e)
        {
            LoadNewOrderForm();
            label6.Text = "New Order";
        }

        private void orderList_btn_Click(object sender, EventArgs e)
        {
            LoadRecieptForm();
            label6.Text = "Payment";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void tableReservation_btn_Click(object sender, EventArgs e)
        {

        }

        private void tableReservation_btn_Click_1(object sender, EventArgs e)
        {
            LoadTableForm();
            label6.Text = "Table Reservation";

        }


        // functions 
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTimeLabel();
        }

        private void DateTimeLabel()
        {
            DateTime currentDateTime = DateTime.Now;
            dateTime_label.Text = $"{currentDateTime.ToString("dddd, MMMM dd, yyyy - hh:mm:ss tt")}";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void home_btn_MouseHover(object sender, EventArgs e)

        {
            home_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");

           tableReservation_btn.BackColor = Color.Transparent;


            orderList_btn.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

         
        }

        private void tableReservation_btn_MouseHover(object sender, EventArgs e)
        {
            home_btn.BackColor = Color.Transparent;

            tableReservation_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");
            button1.BackColor = Color.Transparent;

            orderList_btn.BackColor = Color.Transparent;
        }

        private void orderList_btn_MouseHover(object sender, EventArgs e)
        {
            home_btn.BackColor = Color.Transparent;

            tableReservation_btn.BackColor = Color.Transparent;

            button1.BackColor = Color.Transparent;
            orderList_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");
        }

        private void logOut_btn_MouseHover(object sender, EventArgs e)
        {
           logOut_btn.BackColor = Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
 
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            LoadKitchenForm();
            label6.Text = "On Going Orders";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            home_btn.BackColor = Color.Transparent;

            tableReservation_btn.BackColor = Color.Transparent;

           orderList_btn.BackColor = Color.Transparent;
            button1.BackColor = ColorTranslator.FromHtml("#E1D7A6");
        }
    }
}
