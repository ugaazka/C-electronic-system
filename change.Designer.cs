namespace WinFormsApp5
{
    partial class change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change));
            role = new ComboBox();
            label5 = new Label();
            pass = new TextBox();
            olld = new TextBox();
            user = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            conf = new TextBox();
            button1 = new Button();
            buttonBack = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // role
            // 
            role.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "manager", "admin", "kashier", "employee" });
            role.Location = new Point(198, 74);
            role.Name = "role";
            role.Size = new Size(255, 40);
            role.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(198, 9);
            label5.Name = "label5";
            label5.Size = new Size(242, 31);
            label5.TabIndex = 21;
            label5.Text = "change password";
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(198, 236);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(255, 47);
            pass.TabIndex = 20;
            // 
            // olld
            // 
            olld.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            olld.Location = new Point(198, 181);
            olld.Multiline = true;
            olld.Name = "olld";
            olld.Size = new Size(255, 47);
            olld.TabIndex = 19;
            // 
            // user
            // 
            user.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.Location = new Point(198, 124);
            user.Multiline = true;
            user.Name = "user";
            user.Size = new Size(255, 47);
            user.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(16, 304);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 17;
            label4.Text = "confirm pass";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(7, 196);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 16;
            label2.Text = "Old password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(49, 139);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 15;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(113, 82);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 14;
            label3.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(0, 251);
            label6.Name = "label6";
            label6.Size = new Size(177, 32);
            label6.TabIndex = 23;
            label6.Text = "new password";
            // 
            // conf
            // 
            conf.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conf.Location = new Point(198, 289);
            conf.Multiline = true;
            conf.Name = "conf";
            conf.Size = new Size(255, 47);
            conf.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(64, 354);
            button1.Name = "button1";
            button1.Size = new Size(150, 55);
            button1.TabIndex = 25;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonBack.ForeColor = SystemColors.Highlight;
            buttonBack.Image = (Image)resources.GetObject("buttonBack.Image");
            buttonBack.Location = new Point(820, -1);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(172, 149);
            buttonBack.TabIndex = 35;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(352, 182);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(231, 354);
            button2.Name = "button2";
            button2.Size = new Size(150, 55);
            button2.TabIndex = 37;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.ButtonHighlight;
            search.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = SystemColors.Highlight;
            search.Location = new Point(459, 93);
            search.Name = "search";
            search.Size = new Size(150, 55);
            search.TabIndex = 38;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += button3_Click;
            // 
            // change
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(995, 450);
            Controls.Add(search);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(conf);
            Controls.Add(label6);
            Controls.Add(role);
            Controls.Add(label5);
            Controls.Add(pass);
            Controls.Add(olld);
            Controls.Add(user);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "change";
            Text = "change";
            Load += change_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox role;
        private Label label5;
        private TextBox pass;
        private TextBox olld;
        private TextBox user;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label6;
        private TextBox conf;
        private Button button1;
        private Button buttonBack;
        private DataGridView dataGridView1;
        private Button button2;
        private Button search;
    }
}