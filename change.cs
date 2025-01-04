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
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Validate the old password
                string validateQuery = "SELECT COUNT(*) FROM login WHERE Username = @username AND Password = @oldPassword";

                SqlCommand validateCmd = new SqlCommand(validateQuery, conn);

                // Add parameters to prevent SQL injection
                validateCmd.Parameters.AddWithValue("@username", user.Text);
                validateCmd.Parameters.AddWithValue("@oldPassword", olld.Text);

                // Execute the validation query
                int validationResult = (int)validateCmd.ExecuteScalar();

                if (validationResult > 0)
                {
                    // Check if the new password and confirmation match
                    if (pass.Text == conf.Text)
                    {
                        // Update the password
                        string updateQuery = "UPDATE login SET Password = @newPassword WHERE Username = @username";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);

                        // Add parameters for the update query
                        updateCmd.Parameters.AddWithValue("@username", user.Text);
                        updateCmd.Parameters.AddWithValue("@newPassword", pass.Text);

                        // Execute the update query
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Password update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or old password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the login table
                string query = "SELECT * FROM login WHERE Username = @username";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", user.Text.Trim());

                // Create a SqlDataAdapter to fetch data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the results
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    // No record found
                    MessageBox.Show("No user found with the specified username.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                // Ensure a row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected user's username
                    string usernameToDelete = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the user '" + usernameToDelete + "'?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Open the connection to the database
                        conn.Open();

                        // SQL query to delete the user
                        string deleteQuery = "DELETE FROM login WHERE Username = @username";

                        SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);

                        // Add parameter for the username
                        deleteCmd.Parameters.AddWithValue("@username", usernameToDelete);

                        // Execute the delete query
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView after deletion
                            search.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("User deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the query execution
                MessageBox.Show("An error occurred while deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to fetch all records from the customers table
                string query = "SELECT * FROM login";

                // Create a SqlDataAdapter
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // Create a DataTable to store the results
                DataTable dt = new DataTable();

                // Fill the DataTable with the results
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
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

        private void change_Load(object sender, EventArgs e)
        {
            // Set the form's start position to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set the form size to a specific dimension
            this.Size = new Size(1024, 768); // Adjust width and height as needed

            // Ensure all controls fit properly
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to fetch all records from the 'customers' table
                string query = "SELECT * FROM login";

                // Use SqlDataAdapter to fetch data from the database
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with data from the database
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                conn.Close();
            }
        }
    }

}

