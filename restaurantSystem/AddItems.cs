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
          
            this.FormBorderStyle = FormBorderStyle.None;
            DesignCodes.Borders.SetBorderRadius(additem_btn,30);
            DesignCodes.Borders.SetBorderRadius(back_btn, 30);

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

        private void bgpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
                    }
    }
}
