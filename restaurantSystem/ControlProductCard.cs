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

        public event EventHandler Clicked;
        private DB db = new DB();
      
        public ControlProductCard()
        {
            InitializeComponent();
            pictureBox.Click -= productCard; 
            pictureBox.Click += productCard;

        }







        public string ProductName
        {
            get { return productNameLabel.Text; }
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

        private void productCard(object sender, EventArgs e)
        {
            string productName = productNameLabel.Text;
            Console.WriteLine("PictureBox clicked! Product Name: " + productName);
            
        }

        



    }
}
