namespace WinFormsApp5
{
    partial class addusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addusers));
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            user = new TextBox();
            pass = new TextBox();
            conf = new TextBox();
            label5 = new Label();
            role = new ComboBox();
            button1 = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(45, 95);
            label3.Name = "label3";
            label3.Size = new Size(64, 32);
            label3.TabIndex = 4;
            label3.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(45, 169);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(45, 232);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 6;
            label2.Text = "new password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(45, 309);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 7;
            label4.Text = "confirm pass";
            label4.Click += label4_Click;
            // 
            // user
            // 
            user.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.Location = new Point(239, 169);
            user.Multiline = true;
            user.Name = "user";
            user.Size = new Size(255, 47);
            user.TabIndex = 9;
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass.Location = new Point(239, 232);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(255, 47);
            pass.TabIndex = 10;
            // 
            // conf
            // 
            conf.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conf.Location = new Point(239, 294);
            conf.Multiline = true;
            conf.Name = "conf";
            conf.Size = new Size(255, 47);
            conf.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(298, 9);
            label5.Name = "label5";
            label5.Size = new Size(160, 37);
            label5.TabIndex = 12;
            label5.Text = "new Admin";
            // 
            // role
            // 
            role.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "manager", "admin", "kashier", "employee" });
            role.Location = new Point(239, 106);
            role.Name = "role";
            role.Size = new Size(255, 40);
            role.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(144, 365);
            button1.Name = "button1";
            button1.Size = new Size(150, 55);
            button1.TabIndex = 26;
            button1.Text = "New User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonBack.ForeColor = SystemColors.Highlight;
            buttonBack.Image = (Image)resources.GetObject("buttonBack.Image");
            buttonBack.Location = new Point(713, 240);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(203, 198);
            buttonBack.TabIndex = 34;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // addusers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(917, 450);
            Controls.Add(buttonBack);
            Controls.Add(button1);
            Controls.Add(role);
            Controls.Add(label5);
            Controls.Add(conf);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "addusers";
            Text = "addusers";
            Load += addusers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox user;
        private TextBox pass;
        private TextBox conf;
        private Label label5;
        private ComboBox role;
        private Button button1;
        private Button buttonBack;
    }
}