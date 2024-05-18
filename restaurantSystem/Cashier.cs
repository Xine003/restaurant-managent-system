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
    public partial class Cashier : Form
    {
        private NewOrder newOrderForm;
        private Receipt newRecieptForm;
        private ProductCard productCardForm;

        public Cashier()
        {
            InitializeComponent();
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            home_btn.FlatAppearance.BorderSize = 0;
            tableReservation_btn.FlatAppearance.BorderSize = 0;
            orderList_btn.FlatAppearance.BorderSize = 0;
            logOut_btn.FlatAppearance.BorderSize = 0;
            LoadNewOrderForm();
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
            User user = new User();
            user.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //functions
        private void LoadNewOrderForm()
        {
            // Initialize the dashboard form
            newOrderForm = new NewOrder();
            newOrderForm.TopLevel = false;
            newOrderForm.FormBorderStyle = FormBorderStyle.None;
            newOrderForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newOrderForm);
            newOrderForm.Show();
        }

        private void LoadRecieptForm()
        {
            // Initialize the dashboard form
            newRecieptForm = new Receipt();
            newRecieptForm.TopLevel = false;
            newRecieptForm.FormBorderStyle = FormBorderStyle.None;
            newRecieptForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(newRecieptForm);
            newRecieptForm.Show();
        }

       

        private void home_btn_Click(object sender, EventArgs e)
        {
            LoadNewOrderForm();
        }

        private void orderList_btn_Click(object sender, EventArgs e)
        {
            LoadRecieptForm();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          ProductCard card = new ProductCard();
            card.Show();
        }

        private void tableReservation_btn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
