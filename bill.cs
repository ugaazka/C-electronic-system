using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp5
{
    public partial class bill : Form
    {

        public bill()
        {
            InitializeComponent();
        }
        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void bill_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM bill";

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection to the database
                conn.Open();

                // Define the SQL query to insert a new record into the 'bill' table
                string query = "INSERT INTO bill (payment_method, amount_paid, customer_id) VALUES (@payment_method, @amount_paid, @customer_id)";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@payment_method", payment.Text.Trim());
                cmd.Parameters.AddWithValue("@amount_paid", Convert.ToDecimal(amout.Text.Trim()));
                cmd.Parameters.AddWithValue("@customer_id", Convert.ToInt32(cusID.Text.Trim()));

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Record inserted successfully
                    MessageBox.Show("Record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No rows affected
                    MessageBox.Show("Failed to save the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                conn.Open();

                string query = "SELECT * FROM bill";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while refreshing the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Tallaabada 1: Weydiinta ID qofka
                string inputID = Microsoft.VisualBasic.Interaction.InputBox("Enter Bill ID:", "Update Record", "");

                // Hubi haddii ID la gelin
                if (string.IsNullOrWhiteSpace(inputID))
                {
                    return; // Jooji hawsha haddii ID aan la gelin
                }

                // Convert ID-ga la geliyay
                int billID = Convert.ToInt32(inputID);

                // Open the connection to the database
                conn.Open();

                // Query si loo soo helo xogta qofka ID-giisa leh
                string query = "SELECT * FROM bill WHERE bill_id = @bill_id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bill_id", billID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Tallaabada 2: Weydiinta xog cusub
                    string newCustomerID = Microsoft.VisualBasic.Interaction.InputBox("Customer ID:", "Edit Details", reader["customer_id"].ToString());
                    string newAmountPaid = Microsoft.VisualBasic.Interaction.InputBox("Amount Paid:", "Edit Details", reader["amount_paid"].ToString());
                    string newPaymentMethod = Microsoft.VisualBasic.Interaction.InputBox("Payment Method:", "Edit Details", reader["payment_method"].ToString());

                    // Hubi haddii user-ku dhameystiray buuxinta
                    if (string.IsNullOrWhiteSpace(newCustomerID) || string.IsNullOrWhiteSpace(newAmountPaid) || string.IsNullOrWhiteSpace(newPaymentMethod))
                    {
                        return; // Jooji hawsha haddii xog cusub aan si buuxda loo gelin
                    }

                    // Tallaabada 3: Cusboonaysiinta xogta cusub
                    query = "UPDATE bill SET customer_id = @customer_id, amount_paid = @amount_paid, payment_method = @payment_method WHERE bill_id = @bill_id";

                    SqlCommand updateCmd = new SqlCommand(query, conn);
                    updateCmd.Parameters.AddWithValue("@customer_id", Convert.ToInt32(newCustomerID));
                    updateCmd.Parameters.AddWithValue("@amount_paid", Convert.ToDecimal(newAmountPaid));
                    updateCmd.Parameters.AddWithValue("@payment_method", newPaymentMethod);
                    updateCmd.Parameters.AddWithValue("@bill_id", billID);

                    updateCmd.ExecuteNonQuery();

                    // Fariin guul ah kaliya
                    Microsoft.VisualBasic.Interaction.MsgBox("Updated successfully!", MsgBoxStyle.Information, "Success");
                }
            }
            catch
            {
                // Ignore all errors silently
            }
            finally
            {
                conn.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            try
            {
                // Show InputBox to enter the ID
                string inputID = Microsoft.VisualBasic.Interaction.InputBox("Please enter the ID you want to delete:", "Delete Record", "");

                // Check if the input is empty
                if (string.IsNullOrWhiteSpace(inputID))
                {
                    MessageBox.Show("No ID entered. Operation canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if no ID is provided
                }

                // Convert the input to an integer
                int billID = Convert.ToInt32(inputID);

                // Open the connection to the database
                conn.Open();

                // Define the SQL query to delete a record from the 'bill' table by bill_id
                string query = "DELETE FROM bill WHERE bill_id = @bill_id";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter for bill_id
                cmd.Parameters.AddWithValue("@bill_id", billID);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Record deleted successfully
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView to reflect changes
                   
                }
                else
                {
                    // No record found with the specified ID
                    MessageBox.Show("No record found with the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            biil.Clear();
            amout.Clear();
            cusID.Clear();

            payment.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Show InputBox to enter the ID
                string inputID = Microsoft.VisualBasic.Interaction.InputBox("Please enter the ID you want to search:", "Search Record", "");

                // Check if the input is empty
                if (string.IsNullOrWhiteSpace(inputID))
                {
                    MessageBox.Show("No ID entered. Operation canceled.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if no ID is provided
                }

                // Convert the input to an integer
                int billID = Convert.ToInt32(inputID);

                // Open the connection to the database
                conn.Open();

                // Define the SQL query to search for a record in the 'bill' table by bill_id
                string query = "SELECT * FROM bill WHERE bill_id = @bill_id";

                // Create a SqlCommand object
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameter for bill_id
                cmd.Parameters.AddWithValue("@bill_id", billID);

                // Create a SqlDataAdapter to fetch data
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
                    MessageBox.Show("No record found for the specified ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
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

