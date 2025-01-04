using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
            // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set the form size to a specific dimension
            this.Size = new Size(1024, 768); // Adjust width and height as needed

            // Ensure all controls fit properly
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

            // Capture user input from the form's text boxes

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to check username and password
                string query = "SELECT COUNT(*) FROM login WHERE Username = @username AND Password = @password";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Execute the query and get the result
                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    // Login successful
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to another form or perform any desired action
                    // Example:
                    dashbord mainForm = new dashbord();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
