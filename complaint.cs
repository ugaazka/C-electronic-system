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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp5
{
    public partial class complaint : Form
    {
        public complaint()
        {
            InitializeComponent();
        }
        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void complaint_Load(object sender, EventArgs e)
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

                // Define the SQL query to fetch all records from the 'complaint' table
                string query = "SELECT * FROM complaint";

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

        private void button6_Click(object sender, EventArgs e)
        {
            dashbord dashboard = new dashbord(); // Replace 'Dashboard' with the actual name of your Dashboard form class
            dashboard.Show(); // Show the Dashboard form
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to insert data into the complaint table
                string query = "INSERT INTO complaint (name, address, phone_number, complaint_information) VALUES (@name, @address, @phone_number, @complaint_information)";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());                    // Name TextBox
                cmd.Parameters.AddWithValue("@address", adress.Text.Trim());                      // Address TextBox
                cmd.Parameters.AddWithValue("@phone_number", phone.Text.Trim());                  // Phone Number TextBox
                cmd.Parameters.AddWithValue("@complaint_information", cabasho.Text.Trim()); // Complaint Information TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data saved successfully
                    MessageBox.Show("Complaint saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh DataGridView
                }
                else
                {
                    // No rows were inserted
                    MessageBox.Show("Failed to save the complaint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to update data in the complaint table
                string query = "UPDATE complaint SET address = @address, phone_number = @phone_number, complaint_information = @complaint_information WHERE name = @name";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());                    // Name TextBox
                cmd.Parameters.AddWithValue("@address", adress.Text.Trim());                      // Address TextBox
                cmd.Parameters.AddWithValue("@phone_number", phone.Text.Trim());                  // Phone Number TextBox
                cmd.Parameters.AddWithValue("@complaint_information", cabasho.Text.Trim()); // Complaint Information TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data updated successfully
                    MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     // Refresh DataGridView
                }
                else
                {
                    // No rows were updated
                    MessageBox.Show("Failed to update the complaint. Ensure the name is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to delete a record from the complaint table
                string query = "DELETE FROM complaint WHERE name = @name";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add the parameter for the name
                cmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim()); // Name TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data deleted successfully
                    MessageBox.Show("Complaint deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh DataGridView
                }
                else
                {
                    // No rows were deleted
                    MessageBox.Show("Failed to delete the complaint. Ensure the name is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Show InputBox to enter the name
                string inputName = Microsoft.VisualBasic.Interaction.InputBox("Please enter the Name you want to search:", "Search Record", "");

                // Check if the input is empty
                if (string.IsNullOrWhiteSpace(inputName))
                {
                    MessageBox.Show("No Name entered. Operation canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if no Name is provided
                }

                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the 'complaint' table by name
                string query = "SELECT * FROM complaint WHERE name = @name";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter for name
                cmd.Parameters.AddWithValue("@name", inputName.Trim());

                // Create a DataAdapter to fetch data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a DataTable to store the results
                DataTable dt = new DataTable();

                // Fill the DataTable with data from the query
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    // Show a message if no record is found
                    MessageBox.Show("No complaint found for the specified Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            {
                nameTextBox.Text = string.Empty;
                adress.Text = string.Empty;
                phone.Text = string.Empty;
                cabasho.Text = string.Empty;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM complaint";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
