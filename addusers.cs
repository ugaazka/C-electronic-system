using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class addusers : Form
    {
        public addusers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
            this.Size = new Size(800, 600); // Set the form size (width: 800, height: 600)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Check if the password and confirm password match
                if (pass.Text == conf.Text)
                {
                    // SQL query to insert a new admin user
                    string insertQuery = "INSERT INTO login (Role, Username, Password) VALUES (@role, @username, @password)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                    // Add parameters to prevent SQL injection
                    insertCmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString()); // Assuming cmbRole is a ComboBox
                    insertCmd.Parameters.AddWithValue("@username", user.Text);
                    insertCmd.Parameters.AddWithValue("@password", pass.Text);

                    // Execute the query
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the input fields
                        role.SelectedIndex = -1;
                        user.Clear();
                        pass.Clear();
                        conf.Clear();

                        // Redirect to the dashboard
                        dashbord mainForm = new dashbord();
                        mainForm.Show();
                        this.Hide(); // Hide the current form
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("New password and confirmation password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the connection or query execution
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                conn.Close();
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            dashbord dashboard = new dashbord(); // Replace 'Dashboard' with the actual name of your Dashboard form class
            dashboard.Show(); // Show the Dashboard form
            this.Hide();
        }

        private void addusers_Load(object sender, EventArgs e)
        { // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set the form size to a specific dimension
            this.Size = new Size(1024, 768); // Adjust width and height as needed

            // Ensure all controls fit properly
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}

