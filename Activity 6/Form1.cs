using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKG_Click(object sender, EventArgs e)
        {
            // Here we assign our variables. 
            double weight; double weightKG;
            /* Here we have implemented a try and catch as an exception handler. If the user does not
             enter a set of integers, "Invalid Input" will be displayed to the screen. */
            try
            {
                // Get input from our text box. 
                weight = double.Parse(txtWeight.Text);
                // Assign the value of kilograms to the user's weight multiplied by this decimal value.
                weightKG = weight * 0.45359237;
                // Change the text in the newWeight text box to the rounded value of kilograms and convert the value into a string. 
                txtNewWeight.Text = Convert.ToString(Math.Round(weightKG, 3));
            }
            catch
            {
                //Output a message box with the message "Invalid Input" to the screen. 
                MessageBox.Show("Invalid input.");
            }
        }

        private void btnLBS_Click(object sender, EventArgs e)
        {
            // Here we assign our variables.
            double weight; double weightLBS;
            /* Here we have implemented a try and catch as an exception handler. If the user does not
            enter a set of integers, "Invalid Input" will be displayed to the screen. */
            try
            {
                // Get input from our text box. 
                weight = double.Parse(txtWeight.Text);
                // Assign the value of pounds to the user's weight multiplied by this decimal value. 
                weightLBS = weight * 2.20462262185;
                // Display result and round to three decimal places. 
                txtNewWeight.Text = Convert.ToString(Math.Round(weightLBS, 3));
            }
            catch
            {
                // Display "Invalid Input" in a message box. 
                MessageBox.Show("Invalid Input.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Change the value of the text of all text boxes to nothing. 
            txtWeight.Text = "";
            txtNewWeight.Text = "";
            txtWeight.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the application by invoking the Exit() method. 
            Application.Exit();
        }
    }
    }

