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
    public partial class ordersCard : UserControl
    {
        public ordersCard()
        {
            InitializeComponent();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

            

        }

        public void SetItemName(string itemName)
        {
            itemname.Text = itemName;
        }

    }
}
