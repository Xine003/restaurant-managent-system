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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();

            productsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            addProducts_btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void productsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addProducts_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addProducts(object sender, MouseEventArgs e)
        {
            AddItems add_item = new AddItems();
            add_item.Show();
       }
   }
}
