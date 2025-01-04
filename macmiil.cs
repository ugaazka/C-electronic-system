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
    public partial class macmiil : Form
    {
        public macmiil()
        {
            InitializeComponent();
        }
        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void macmiil_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM customers";

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to insert data into the customers table
                string query = "INSERT INTO customers (name, phone_number, address) VALUES (@name, @phone_number, @address)";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", magac.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", tilifon.Text.Trim());
                cmd.Parameters.AddWithValue("@address", qaybta.Text.Trim());

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data saved successfully
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView

                }
                else
                {
                    // No rows were inserted
                    MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO customers (name, phone_number, address) VALUES (@name, @phone_number, @address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", magac.Text.Trim());
                cmd.Parameters.AddWithValue("@phone_number", tilifon.Text.Trim());
                cmd.Parameters.AddWithValue("@address", qaybta.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update customer. Ensure the name is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "DELETE FROM customers WHERE name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", magac.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to delete customer. Ensure the name is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the customers table
                string query = "SELECT * FROM customers WHERE name = @name";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@name", magac.Text.Trim());

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
                    MessageBox.Show("No customer found with the specified name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            {
                magac.Text = string.Empty;
                tilifon.Text = string.Empty;
                qaybta.Text = string.Empty;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            {
                dashbord dashboard = new dashbord(); // Replace 'Dashboard' with the actual name of your Dashboard form class
                dashboard.Show(); // Show the Dashboard form
                this.Hide();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to fetch all records from the customers table
                string query = "SELECT * FROM customers";

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

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
