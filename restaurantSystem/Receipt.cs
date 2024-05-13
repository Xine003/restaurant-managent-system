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

            // Attach the same event handler to all the buttons
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.MouseClick += Button_Click;
                }
            }
        }
        private double aDueAmount = 5000.0;
        private string sukli_TextChange; 

        // Event handler for all the buttons
        private void Button_Click(object sender, MouseEventArgs e)
        {
            // Cast the sender object to a Button
            if (sender is Button clickedButton)
            {
                // Append the clicked button's text to textBox2
                textBox2.Text += clickedButton.Text;
            }
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num7Click(object sender, MouseEventArgs e)
        {
            
            // Append the number 7 to textBox2
            textBox2.Text += "7";
        }

        private void decimalClick(object sender, MouseEventArgs e)
        {
           
            // Append the number 7 to textBox2
            textBox2.Text += ".";
        }

        private void num4Click(object sender, MouseEventArgs e)
        {
           
            // Append the number 7 to textBox2
            textBox2.Text += "4";
        }


        private void num3Click(object sender, MouseEventArgs e)
        {
            
            // Append the number 7 to textBox2
            textBox2.Text += "3";
        }


        private void clearClick(object sender, MouseEventArgs e)
        {
            // Clear the text in textBox2
            textBox2.Text = "";
        }


        private void num8Click(object sender, MouseEventArgs e)
        {
            
            // Append the number 7 to textBox2
            textBox2.Text += "8";
        }


        private void num5Click(object sender, MouseEventArgs e)
        {
           
            // Append the number 7 to textBox2
            textBox2.Text += "5";
        }


        private void nuum2Click(object sender, MouseEventArgs e)
        {
            // Append the number 7 to textBox2
            textBox2.Text += "2";
        }


        private void num0Click(object sender, MouseEventArgs e)
        {
          
            // Append the number 7 to textBox2
            textBox2.Text += "0";
        }


        private void deleteClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                // Remove the last character from textBox2
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private void num9Click(object sender, MouseEventArgs e)
        {
            
            // Append the number 7 to textBox2
            textBox2.Text += "9";
        }


        private void num6Click(object sender, MouseEventArgs e)
        {
           
            // Append the number 7 to textBox2
            textBox2.Text += "6";
        }


        private void num1Click(object sender, MouseEventArgs e)
        {
          
            // Append the number 7 to textBox2
            textBox2.Text += "1";
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void equalClick(object sender, MouseEventArgs e)
        {
            double amountPaid;

            // Try to parse the text in textBox2 to a double
            if (double.TryParse(textBox2.Text, out amountPaid))
            {
                // Subtract the amount paid from aDue
                aDueAmount -= amountPaid;

                // Display the remaining amount due in the sukli TextBox
                sukli_TextChange = aDueAmount.ToString();
            }
            else
            {
                // If the text cannot be parsed to a double, display an error message or handle it accordingly
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tAmount(object sender, MouseEventArgs e)
        {

        }

      

        private void aDue(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void sukli_TextChanged(object sender, EventArgs e)
        {
          
        }

       

        
    }
}
