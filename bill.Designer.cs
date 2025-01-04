namespace WinFormsApp5
{
    partial class bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bill));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            cusID = new TextBox();
            biil = new TextBox();
            amout = new TextBox();
            payment = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 1;
            label1.Text = "Bill Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(32, 93);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 3;
            label3.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(32, 172);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 4;
            label2.Text = "Bill ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(32, 243);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 5;
            label4.Text = "Amout Paid";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(32, 315);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
            label5.TabIndex = 6;
            label5.Text = "Payment Method";
            // 
            // cusID
            // 
            cusID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cusID.Location = new Point(249, 93);
            cusID.Multiline = true;
            cusID.Name = "cusID";
            cusID.Size = new Size(255, 47);
            cusID.TabIndex = 7;
            // 
            // biil
            // 
            biil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            biil.Location = new Point(249, 172);
            biil.Multiline = true;
            biil.Name = "biil";
            biil.Size = new Size(255, 47);
            biil.TabIndex = 8;
            // 
            // amout
            // 
            amout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amout.Location = new Point(249, 243);
            amout.Multiline = true;
            amout.Name = "amout";
            amout.Size = new Size(255, 47);
            amout.TabIndex = 9;
            // 
            // payment
            // 
            payment.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment.FormattingEnabled = true;
            payment.Items.AddRange(new object[] { "kash", "card" });
            payment.Location = new Point(249, 312);
            payment.Name = "payment";
            payment.Size = new Size(255, 33);
            payment.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(32, 369);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(185, 369);
            button2.Name = "button2";
            button2.Size = new Size(126, 55);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(335, 369);
            button3.Name = "button3";
            button3.Size = new Size(126, 55);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(485, 369);
            button4.Name = "button4";
            button4.Size = new Size(126, 55);
            button4.TabIndex = 14;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(525, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 182);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Highlight;
            button5.Location = new Point(658, 32);
            button5.Name = "button5";
            button5.Size = new Size(126, 55);
            button5.TabIndex = 16;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Highlight;
            button6.Location = new Point(748, 281);
            button6.Name = "button6";
            button6.Size = new Size(216, 199);
            button6.TabIndex = 18;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(966, 474);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(payment);
            Controls.Add(amout);
            Controls.Add(biil);
            Controls.Add(cusID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "bill";
            Text = "bill";
            Load += bill_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox cusID;
        private TextBox biil;
        private TextBox amout;
        private ComboBox payment;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
    }
}