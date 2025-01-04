using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class employee : Form
    {

        public employee()
        {
            InitializeComponent();
        }
        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
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
                conn.Open();

                string query = "SELECT * FROM employee";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashbord dashboard = new dashbord(); // Replace 'Dashboard' with the actual name of your Dashboard form class
            dashboard.Show(); // Show the Dashboard form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to insert data into the Employee table
                string query = "INSERT INTO Employee (EmployeeID, EmployeeName, EmployeePosition, EmployeeStatus) VALUES (@ID, @Name, @Position, @Status)";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@ID", employeeID.Text.Trim());                // Employee ID TextBox
                cmd.Parameters.AddWithValue("@Name", emplonme.Text.Trim());            // Employee Name TextBox
                cmd.Parameters.AddWithValue("@Position", position.Text.Trim());    // Employee Position TextBox
                cmd.Parameters.AddWithValue("@Status", combo.Text.Trim());        // Employee Status TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data saved successfully
                    MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, refresh DataGridView or clear input fields
                }
                else
                {
                    // No rows were inserted
                    MessageBox.Show("Failed to save the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the Employee table
                string query = "SELECT * FROM Employee WHERE EmployeeID = @ID";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add the parameter for EmployeeID
                cmd.Parameters.AddWithValue("@ID", employeeID.Text.Trim()); // Employee ID TextBox

                // Create a DataAdapter to fetch data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the query results
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    // No record found
                    MessageBox.Show("No employee found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                employeeID.Text = string.Empty;
                emplonme.Text = string.Empty;
                position.Text = string.Empty;
                combo.SelectedIndex = -1; // Clear ComboBox selection
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the Employee table
                string query = "SELECT * FROM Employee WHERE EmployeeID = @ID";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add the parameter for EmployeeID
                cmd.Parameters.AddWithValue("@ID", employeeID.Text.Trim()); // Employee ID TextBox

                // Create a DataAdapter to fetch data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the query results
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    // No record found
                    MessageBox.Show("No employee found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                // Define the SQL query to delete a record from the Employee table
                string query = "DELETE FROM Employee WHERE EmployeeID = @ID";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add the parameter for EmployeeID
                cmd.Parameters.AddWithValue("@ID", employeeID.Text.Trim()); // Employee ID TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data deleted successfully
                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, refresh DataGridView or clear input fields
                }
                else
                {
                    // No rows were deleted
                    MessageBox.Show("Failed to delete the employee. Ensure the EmployeeID is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Define the SQL query to update data in the Employee table
                string query = "UPDATE Employee SET EmployeeName = @Name, EmployeePosition = @Position, EmployeeStatus = @Status WHERE EmployeeID = @ID";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@ID", employeeID.Text.Trim());                // Employee ID TextBox
                cmd.Parameters.AddWithValue("@Name", emplonme.Text.Trim());            // Employee Name TextBox
                cmd.Parameters.AddWithValue("@Position", position.Text.Trim());    // Employee Position TextBox
                cmd.Parameters.AddWithValue("@Status", combo.Text.Trim());        // Employee Status TextBox

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data updated successfully
                    MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Optionally, refresh DataGridView or clear input fields
                }
                else
                {
                    // No rows were updated
                    MessageBox.Show("Failed to update the employee. Ensure the EmployeeID is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

