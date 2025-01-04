namespace WinFormsApp5
{
    partial class complaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(complaint));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            adress = new TextBox();
            phone = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            complain = new Label();
            cabasho = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(264, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 37);
            label1.TabIndex = 1;
            label1.Text = "complaint Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 2;
            label2.Text = "name";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 4;
            label4.Text = "address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 215);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 5;
            label3.Text = "phone number";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(199, 85);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(255, 47);
            nameTextBox.TabIndex = 6;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // adress
            // 
            adress.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adress.Location = new Point(199, 147);
            adress.Multiline = true;
            adress.Name = "adress";
            adress.Size = new Size(255, 47);
            adress.TabIndex = 7;
            adress.TextChanged += adress_TextChanged;
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone.Location = new Point(199, 215);
            phone.Multiline = true;
            phone.Name = "phone";
            phone.Size = new Size(255, 47);
            phone.TabIndex = 8;
            phone.TextChanged += phone_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(42, 333);
            button1.Name = "button1";
            button1.Size = new Size(126, 55);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(190, 333);
            button2.Name = "button2";
            button2.Size = new Size(126, 55);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(339, 333);
            button3.Name = "button3";
            button3.Size = new Size(126, 55);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Desktop;
            button4.Location = new Point(488, 333);
            button4.Name = "button4";
            button4.Size = new Size(126, 55);
            button4.TabIndex = 13;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(532, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(433, 177);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.Desktop;
            button5.Location = new Point(684, 35);
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
            button6.Location = new Point(749, 271);
            button6.Name = "button6";
            button6.Size = new Size(216, 197);
            button6.TabIndex = 17;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // complain
            // 
            complain.AutoSize = true;
            complain.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            complain.Location = new Point(12, 271);
            complain.Name = "complain";
            complain.Size = new Size(129, 32);
            complain.TabIndex = 18;
            complain.Text = "complaint";
            // 
            // cabasho
            // 
            cabasho.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cabasho.Location = new Point(201, 271);
            cabasho.Multiline = true;
            cabasho.Name = "cabasho";
            cabasho.Size = new Size(255, 47);
            cabasho.TabIndex = 19;
            // 
            // complaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(977, 464);
            Controls.Add(cabasho);
            Controls.Add(complain);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phone);
            Controls.Add(adress);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "complaint";
            Text = "complaint";
            Load += complaint_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox nameTextBox; // Updated variable name
        private TextBox adress;
        private TextBox phone;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button6;
        private Label complain;
        private TextBox cabasho;
    }
}
