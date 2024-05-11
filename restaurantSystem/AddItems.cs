using MySql.Data.MySqlClient;
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
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
            bgpanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            
           


            //open connection
          
        }

        private void i_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
