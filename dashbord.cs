using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            macmiil customerForm = new macmiil();
            customerForm.Show();

        }
        private void btnCustomerRegistration_Click(object sender, EventArgs e)

        {
            bill customerForm = new bill();
            customerForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bill billfrom = new bill();
            billfrom.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employee employeefrom = new employee();
            employeefrom.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            complaint complaintfrom = new complaint(); // Replace 'CustomerForm' with the actual name of your Customer form
            complaintfrom.Show(); // Show the Customer form
                                  // Hide the current Dashboard form
        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                addusers addusersfrom = new addusers(); // Replace 'CustomerForm' with the actual name of your Customer form
                addusersfrom.Show(); // Show the Customer form
                                     // Hide the current Dashboard form
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                change changefrom = new change(); // Replace 'CustomerForm' with the actual name of your Customer form
                changefrom.Show(); // Show the Customer form
                // Hide the current Dashboard form
            }
        }

        private void dashbord_Load(object sender, EventArgs e)
        {
            // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set the form size to a specific dimension
            this.Size = new Size(1024, 768); // Adjust width and height as needed

            // Ensure all controls fit properly
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            main_dashboard main_Dashboard = new main_dashboard(); // Replace 'Dashboard' with the actual name of your Dashboard form class
            main_Dashboard.Show(); // Show the Dashboard form
            this.Hide();
        }
    }

}
