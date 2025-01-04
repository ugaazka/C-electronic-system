using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp5
{
    public partial class main_dashboard : Form
    {
        public main_dashboard()
        {
            InitializeComponent();
        }

        // Define the connection string (update it with your database details)
        SqlConnection conn = new SqlConnection(@"Data Source=UGAZ\UGAAZKA;Initial Catalog=wadajirsystem;Integrated Security=True");

        private void main_dashboard_Load(object sender, EventArgs e)
        {
            // Load data and chart
            LoadData();

            // Remove cursor focus from textboxes
            this.ActiveControl = label1; // Set focus to a non-editable control like a label
        }

        private void LoadData()
        {
            try
            {
                // Open the database connection
                conn.Open();

                // Fetch totals for customers, employees, and bill
                string queryCustomers = "SELECT COUNT(*) FROM customers";
                string queryEmployees = "SELECT COUNT(*) FROM employee";
                string queryTotalPaid = "SELECT SUM(amount_paid) FROM bill";

                // Get total customers
                SqlCommand cmdCustomers = new SqlCommand(queryCustomers, conn);
                int totalCustomers = (int)cmdCustomers.ExecuteScalar();
                txtTotalCustomer.Text = totalCustomers.ToString();

                // Get total employees
                SqlCommand cmdEmployees = new SqlCommand(queryEmployees, conn);
                int totalEmployees = (int)cmdEmployees.ExecuteScalar();
                txtTotalEmployee.Text = totalEmployees.ToString();

                // Get total paid
                SqlCommand cmdTotalPaid = new SqlCommand(queryTotalPaid, conn);
                object result = cmdTotalPaid.ExecuteScalar();
                decimal totalPaid = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                txtTotalPaid.Text = totalPaid.ToString("C"); // Format as currency

                // Load data into the chart
                LoadPieChart(totalCustomers, totalEmployees, totalPaid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Close the database connection
                conn.Close();
            }
        }

        private void LoadPieChart(int totalCustomers, int totalEmployees, decimal totalPaid)
        {
            try
            {
                // Clear existing chart data
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.ChartAreas[0].AxisX.Interval = 1; // Ensure bars are separated properly

                // Set chart title
                chart1.Titles.Add("Data Overview");

                // Add Bar Series for Customers
                Series barCustomers = new Series
                {
                    Name = "Customers",
                    ChartType = SeriesChartType.Column, // Bar Chart
                    Color = System.Drawing.Color.Blue, // Customers - Blue
                    IsValueShownAsLabel = true, // Show values on bars
                    BorderWidth = 2
                };
                chart1.Series.Add(barCustomers);
                barCustomers.Points.AddY(totalCustomers);

                // Add Bar Series for Employees
                Series barEmployees = new Series
                {
                    Name = "Employees",
                    ChartType = SeriesChartType.Column,
                    Color = System.Drawing.Color.Green, // Employees - Green
                    IsValueShownAsLabel = true,
                    BorderWidth = 2
                };
                chart1.Series.Add(barEmployees);
                barEmployees.Points.AddY(totalEmployees);

                // Add Bar Series for Total Paid
                Series barTotalPaid = new Series
                {
                    Name = "Total Paid",
                    ChartType = SeriesChartType.Column,
                    Color = System.Drawing.Color.Orange, // Total Paid - Orange
                    IsValueShownAsLabel = true,
                    BorderWidth = 2
                };
                chart1.Series.Add(barTotalPaid);
                barTotalPaid.Points.AddY((double)totalPaid); // Ensure it's cast to double for display

                // Adjust bar width (size of the bars)
                foreach (var series in chart1.Series)
                {
                    series["PointWidth"] = "0.6"; // Increase the bar width
                }

                // Set Axis Titles
                chart1.ChartAreas[0].AxisX.Title = "Categories";
                chart1.ChartAreas[0].AxisY.Title = "Values";

                // Ensure legends are shown
                if (chart1.Legends.Count > 0)
                {
                    chart1.Legends[0].Enabled = true;
                }
                else
                {
                    chart1.Legends.Add(new Legend("Legend") { Enabled = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chart Error: {ex.Message}");
            }

        }

        private void employeeID_TextChanged(object sender, EventArgs e)
        
        {
            dashbord dashboard = new dashbord(); // Replace 'Dashboard' with the actual name of your Dashboard form class
            dashboard.Show(); // Show the Dashboard form
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
    }
}
