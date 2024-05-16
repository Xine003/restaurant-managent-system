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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            DesignCodes.Borders.SetBorderRadius(orderSummary, 30);
            DesignCodes.Borders.SetBorderRadius(receiptProduct, 30);

        }

        private void orderSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }


        private void num1_Click(object sender, MouseEventArgs e, TextBox sampleDisplay)
        {
            PictureBox num1 = (PictureBox)sender;
            sampleDisplay.Text += num1.Tag.ToString();
        }



        private void num2_Click(object sender, MouseEventArgs e)
        {

        }

        private void num3_Click(object sender, MouseEventArgs e)
        {

        }

        private void clear_Click(object sender, MouseEventArgs e)
        {

        }

        private void num4_Click(object sender, MouseEventArgs e)
        {

        }

        private void num5_Click(object sender, MouseEventArgs e)
        {

        }

        private void num6_Click(object sender, MouseEventArgs e)
        {

        }

        private void delete_Click(object sender, MouseEventArgs e)
        {

        }

        private void decimal_Click(object sender, MouseEventArgs e)
        {

        }

        private void num0_Click(object sender, MouseEventArgs e)
        {

        }

        private void enter_Click(object sender, MouseEventArgs e)
        {

        }

       

        private void receiptProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num1btn.Text;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
                    }

        private void num2btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num2btn.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num3btn.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = "";
        }

        private void num4btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num4btn.Text;
        }

        private void num5btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num5btn.Text;
        }

        private void num6btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num6btn.Text;
        }

        private void num7btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num7btn.Text;
        }

        private void num8btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num8btn.Text;
        }

        private void num9btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num9btn.Text;
        }

        private void decimalbtn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + decimalbtn.Text;

        }

        private void num0btn_Click(object sender, EventArgs e)
        {
            sampleDisplay.Text = sampleDisplay.Text + num0btn.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sampleDisplay.Text.Length > 0)
            {
                sampleDisplay.Text = sampleDisplay.Text.Substring(0, sampleDisplay.Text.Length - 1);
            }
        }
    }
    
}
        

