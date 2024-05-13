using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurantSystem
{
    public partial class ControlProductCard : UserControl
    {

        private DB db = new DB();

        public ControlProductCard()
        {
            InitializeComponent();
            
        }

        public void LoadDataFromDatabase(string productName, string productPrice)
        {
            productNameLabel.Text = productName;
            productPriceLabel.Text = productPrice;
        }

        public void LoadImageFromDatabase(Image image)
        {
            pictureBox.Image = image;
        }
    }
}
