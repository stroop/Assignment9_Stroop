using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Jacob Stroop
CIS353 - Assignment 9
2/14/16
*/

namespace Assignment9_Stroop
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        // method called when submit button is clicked
        private void submitBtn_Click(object sender, EventArgs e)
        {
            // declare total price variable
            double totalPrice = 0.00;

            // declare constants
            const double Compact = 19.95;
            const double Standard = 24.95;
            const double Luxury = 39.00;

            // calculate days by subtracting todays date from selected date
            int days = Convert.ToInt32((monthCalendar.SelectionStart - monthCalendar.TodayDate).TotalDays);

            // if user selects a present or past date, display error and return
            if (days <= 0)
            {
                MessageBox.Show("Please select a future date.", "Invalid Date");
                return;
            }

            // else/if block calculates price
            // based on radio button currently selected
            if (compactRBtn.Checked)
            {
                totalPrice = Compact * days;
            }
            else if (standardRBtn.Checked)
            {
                totalPrice = Standard * days;
            }
            else if(luxuryRBtn.Checked)
            {
                totalPrice = Luxury * days;
            }

            // set labels for number of days and total price
            daysLabel.Text = "Rental Days: " + days;
            totalPriceLabel.Text = "Total Price: " + totalPrice.ToString("C");
        }

        // method calls dispose to exit application
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
