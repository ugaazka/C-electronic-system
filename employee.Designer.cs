namespace WinFormsApp5
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            employeeID = new TextBox();
            emplonme = new TextBox();
            position = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            combo = new ComboBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(292, 13);
            label1.Name = "label1";
            label1.Size = new Size(352, 40);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(95, 89);
            label2.Name = "label2";
            label2.Size = new Size(158, 32);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(95, 167);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 2;
            label3.Text = "Employee name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(95, 235);
            label4.Name = "label4";
            label4.Size = new Size(237, 32);
            label4.TabIndex = 3;
            label4.Text = "Employee possition";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(95, 300);
            label5.Name = "label5";
            label5.Size = new Size(200, 32);
            label5.TabIndex = 4;
            label5.Text = "Employee status";
            // 
            // employeeID
            // 
            employeeID.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeID.Location = new Point(355, 74);
            employeeID.Multiline = true;
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(255, 47);
            employeeID.TabIndex = 5;
            // 
            // emplonme
            // 
            emplonme.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emplonme.Location = new Point(355, 152);
            emplonme.Multiline = true;
            emplonme.Name = "emplonme";
            emplonme.Size = new Size(255, 47);
            emplonme.TabIndex = 6;
            // 
            // position
            // 
            position.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            position.Location = new Point(355, 220);
            position.Multiline = true;
            position.Name = "position";
            position.Size = new Size(255, 47);
            position.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(95, 365);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(250, 365);
            button2.Name = "button2";
            button2.Size = new Size(126, 55);
            button2.TabIndex = 10;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(400, 365);
            button3.Name = "button3";
            button3.Size = new Size(126, 55);
            button3.TabIndex = 11;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ScrollBar;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(549, 365);
            button4.Name = "button4";
            button4.Size = new Size(126, 55);
            button4.TabIndex = 12;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(767, 13);
            button5.Name = "button5";
            button5.Size = new Size(126, 55);
            button5.TabIndex = 13;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(616, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(407, 193);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // combo
            // 
            combo.DisplayMember = "active ";
            combo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo.FormattingEnabled = true;
            combo.Items.AddRange(new object[] { "active", "ina active" });
            combo.Location = new Point(355, 289);
            combo.Name = "combo";
            combo.Size = new Size(255, 40);
            combo.TabIndex = 15;
            combo.ValueMember = "ina active";
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Highlight;
            button6.Location = new Point(807, 273);
            button6.Name = "button6";
            button6.Size = new Size(216, 197);
            button6.TabIndex = 18;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1024, 473);
            Controls.Add(button6);
            Controls.Add(combo);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(position);
            Controls.Add(emplonme);
            Controls.Add(employeeID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "employee";
            Text = "employee";
            Load += employee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox employeeID;
        private TextBox emplonme;
        private TextBox position;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox combo;
        private Button button6;
    }
}