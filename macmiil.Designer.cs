namespace WinFormsApp5
{
    partial class macmiil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(macmiil));
            buttonBack = new Button();
            buttonSearch = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            qaybta = new TextBox();
            tilifon = new TextBox();
            magac = new TextBox();
            address = new Label();
            phone = new Label();
            name = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonBack.ForeColor = SystemColors.Highlight;
            buttonBack.Image = (Image)resources.GetObject("buttonBack.Image");
            buttonBack.Location = new Point(672, 256);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(203, 198);
            buttonBack.TabIndex = 33;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonSearch.Location = new Point(614, 30);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(128, 49);
            buttonSearch.TabIndex = 32;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonClear.Location = new Point(470, 290);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(128, 49);
            buttonClear.TabIndex = 31;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonDelete.Location = new Point(312, 290);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 49);
            buttonDelete.TabIndex = 30;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonUpdate.Location = new Point(160, 290);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(128, 49);
            buttonUpdate.TabIndex = 29;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonSave.Location = new Point(12, 290);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(128, 49);
            buttonSave.TabIndex = 28;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(502, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(373, 165);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // qaybta
            // 
            qaybta.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qaybta.Location = new Point(224, 218);
            qaybta.Multiline = true;
            qaybta.Name = "qaybta";
            qaybta.Size = new Size(272, 39);
            qaybta.TabIndex = 26;
            // 
            // tilifon
            // 
            tilifon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tilifon.Location = new Point(224, 154);
            tilifon.Multiline = true;
            tilifon.Name = "tilifon";
            tilifon.Size = new Size(272, 39);
            tilifon.TabIndex = 25;
            // 
            // magac
            // 
            magac.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            magac.Location = new Point(224, 85);
            magac.Multiline = true;
            magac.Name = "magac";
            magac.Size = new Size(272, 39);
            magac.TabIndex = 24;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            address.Location = new Point(12, 218);
            address.Name = "address";
            address.Size = new Size(106, 32);
            address.TabIndex = 23;
            address.Text = "Address";
            address.Click += addressLabel_Click;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            phone.Location = new Point(12, 154);
            phone.Name = "phone";
            phone.Size = new Size(187, 32);
            phone.TabIndex = 22;
            phone.Text = "Phone Number";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            name.Location = new Point(12, 88);
            name.Name = "name";
            name.Size = new Size(129, 32);
            name.TabIndex = 21;
            name.Text = "Full Name";
            name.Click += name_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 37);
            label1.TabIndex = 20;
            label1.Text = "Customer Registration";
            // 
            // macmiil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(887, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonSearch);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Controls.Add(qaybta);
            Controls.Add(tilifon);
            Controls.Add(magac);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(name);
            Controls.Add(label1);
            Name = "macmiil";
            Text = "macmiil";
            Load += macmiil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonSearch;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonSave;
        private DataGridView dataGridView1;
        private TextBox qaybta;
        private TextBox tilifon;
        private TextBox magac;
        private Label address;
        private Label phone;
        private Label name;
        private Label label1;
    }
}