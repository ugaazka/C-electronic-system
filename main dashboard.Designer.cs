namespace WinFormsApp5
{
    partial class main_dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_dashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTotalCustomer = new TextBox();
            txtTotalPaid = new TextBox();
            txtTotalEmployee = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 40);
            label1.TabIndex = 1;
            label1.Text = "dynamic dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 2;
            label2.Text = "total Customers";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(223, 32);
            label3.TabIndex = 3;
            label3.Text = "Total amount paid";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(12, 222);
            label4.Name = "label4";
            label4.Size = new Size(219, 32);
            label4.TabIndex = 4;
            label4.Text = "Activity employee";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTotalCustomer
            // 
            txtTotalCustomer.AccessibleName = "";
            txtTotalCustomer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalCustomer.Location = new Point(264, 81);
            txtTotalCustomer.Multiline = true;
            txtTotalCustomer.Name = "txtTotalCustomer";
            txtTotalCustomer.ReadOnly = true;
            txtTotalCustomer.Size = new Size(253, 47);
            txtTotalCustomer.TabIndex = 6;
            txtTotalCustomer.TextChanged += employeeID_TextChanged;
            // 
            // txtTotalPaid
            // 
            txtTotalPaid.AccessibleName = "";
            txtTotalPaid.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPaid.Location = new Point(264, 142);
            txtTotalPaid.Multiline = true;
            txtTotalPaid.Name = "txtTotalPaid";
            txtTotalPaid.ReadOnly = true;
            txtTotalPaid.Size = new Size(253, 47);
            txtTotalPaid.TabIndex = 7;
            txtTotalPaid.TextChanged += textBox1_TextChanged;
            // 
            // txtTotalEmployee
            // 
            txtTotalEmployee.AccessibleName = "";
            txtTotalEmployee.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalEmployee.Location = new Point(264, 207);
            txtTotalEmployee.Multiline = true;
            txtTotalEmployee.Name = "txtTotalEmployee";
            txtTotalEmployee.ReadOnly = true;
            txtTotalEmployee.Size = new Size(253, 47);
            txtTotalEmployee.TabIndex = 8;
            txtTotalEmployee.TextChanged += textBox2_TextChanged;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(534, 81);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // main_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(966, 450);
            Controls.Add(chart1);
            Controls.Add(txtTotalEmployee);
            Controls.Add(txtTotalPaid);
            Controls.Add(txtTotalCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "main_dashboard";
            Text = "main_dashboard";
            Load += main_dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTotalCustomer;
        private TextBox txtTotalPaid;
        private TextBox txtTotalEmployee;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}