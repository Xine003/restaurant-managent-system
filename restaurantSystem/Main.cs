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
    public partial class Main : Form
    {
        private Timer timer;
        private Dashboard dashboardForm;
        private Order orderForm;
        private Products productsForm;
        private Users usersForm;

        public Main()
        {
            InitializeComponent();

            navbar.BackgroundImageLayout = ImageLayout.Stretch;
            linepanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;

            home_btn.FlatAppearance.BorderSize = 0;
            foodcategory_btn.FlatAppearance.BorderSize = 0;
            products_btn.FlatAppearance.BorderSize = 0;
            employee_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatAppearance.BorderSize = 0;

            DesignCodes.Borders.SetBorderRadius(home_btn, 20);
            DesignCodes.Borders.SetBorderRadius(foodcategory_btn, 20);
            DesignCodes.Borders.SetBorderRadius(products_btn, 20);
            DesignCodes.Borders.SetBorderRadius(employee_btn, 20);
            DesignCodes.Borders.SetBorderRadius(logout_btn, 20);

            LoadDashboardForm();

            //timer to tick the time
            timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();

            DateTimeLabel();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadDashboardForm();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            LoadCategoryForm();
            dashboard_Label.Text = "Category";
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            LoadUsersForm();

            dashboard_Label.Text = "Employee";
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }

        

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void linepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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


        private void LoadDashboardForm()
        {
            // Initialize the dashboard form
            dashboardForm = new Dashboard();
            dashboardForm.TopLevel = false;
            dashboardForm.FormBorderStyle = FormBorderStyle.None;
            dashboardForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(dashboardForm);
            dashboardForm.Show();
        }
        private void LoadCategoryForm()
        {
            orderForm = new Order();
            orderForm.TopLevel = false;
            orderForm.FormBorderStyle = FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(orderForm); 
            orderForm.Show();
        }

        private void LoadProductsForm()
        {
            productsForm = new Products();
            productsForm.TopLevel = false;
            productsForm.FormBorderStyle = FormBorderStyle.None;
            productsForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(productsForm); // Add productsForm to the dashboard_panel
            productsForm.Show();
        }
        private void LoadUsersForm()
        {
            usersForm = new Users();
            usersForm.TopLevel = false;
            usersForm.FormBorderStyle = FormBorderStyle.None;
            usersForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(usersForm); // Add productsForm to the dashboard_panel
            usersForm.Show();
        }






        private void dateTime_label_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            LoadProductsForm();
            dashboard_Label.Text = "Products";
        }

        private void loadDashboard(object sender, EventArgs e)
        {
            LoadDashboardForm();
            dashboard_Label.Text = "Dashboard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addEmployee add = new addEmployee();
            add.Show();
        }
    }
}
