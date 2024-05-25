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
        private Coupons couponForm;
        private Products productsForm;
        private Users usersForm;

        public Main()
        {
            InitializeComponent();

            navbar.BackgroundImageLayout = ImageLayout.Stretch;
            linepanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;

            home_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");
           



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

        private void LoadCouponForm() {

            couponForm = new Coupons();
            couponForm.TopLevel = false;
            couponForm.FormBorderStyle = FormBorderStyle.None;
            couponForm.Dock = DockStyle.Fill;
            dashboard_panel.Controls.Clear();
            dashboard_panel.Controls.Add(couponForm); // Add productsForm to the dashboard_panel
            couponForm.Show();

        }




        private void dateTime_label_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
             
                this.Hide();
                User user = new User();
                user.Show();
            }
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
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadCouponForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void home_btn_MouseHover(object sender, EventArgs e)
        {
            home_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");
          

            products_btn.BackColor = Color.Transparent;
            

            employee_btn.BackColor = Color.Transparent;


            button1.BackColor = Color.Transparent;

        }

        private void products_btn_MouseHover(object sender, EventArgs e)
        {
            products_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");
           

            home_btn.BackColor = Color.Transparent;


            employee_btn.BackColor = Color.Transparent;


            button1.BackColor = Color.Transparent;
        }

        private void employee_btn_MouseHover(object sender, EventArgs e)
        {
            employee_btn.BackColor = ColorTranslator.FromHtml("#E1D7A6");

            products_btn.BackColor = Color.Transparent;


            home_btn.BackColor = Color.Transparent;


            button1.BackColor = Color.Transparent;

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           button1.BackColor = ColorTranslator.FromHtml("#E1D7A6");

            products_btn.BackColor = Color.Transparent;


            employee_btn.BackColor = Color.Transparent;


           home_btn.BackColor = Color.Transparent;


        }

        private void logout_btn_MouseHover(object sender, EventArgs e)
        {
            logout_btn.BackColor = Color.Transparent;

        }
    }
}
