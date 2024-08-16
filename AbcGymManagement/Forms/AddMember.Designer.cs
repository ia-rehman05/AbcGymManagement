namespace AbcGymManagement.Forms
{
    partial class AddMember
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
            lblAddMember = new Label();
            lblName = new Label();
            pictureBox18 = new PictureBox();
            lblAge = new Label();
            lblGender = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            txtContactNumber = new TextBox();
            txtEmail = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            btnBack = new Button();
            label1 = new Label();
            cmbTrainer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAddMember
            // 
            lblAddMember.AutoSize = true;
            lblAddMember.BackColor = Color.FromArgb(64, 64, 64);
            lblAddMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddMember.ForeColor = SystemColors.ButtonHighlight;
            lblAddMember.Location = new Point(331, 131);
            lblAddMember.Name = "lblAddMember";
            lblAddMember.Size = new Size(164, 32);
            lblAddMember.TabIndex = 3;
            lblAddMember.Text = "Add Member";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(309, 235);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.Untitled_1;
            pictureBox18.Location = new Point(33, 65);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(788, 174);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 5;
            pictureBox18.TabStop = false;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(309, 291);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 24);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(309, 350);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 24);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1018, 235);
            label4.Name = "label4";
            label4.Size = new Size(155, 24);
            label4.TabIndex = 4;
            label4.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1018, 289);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1018, 344);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // txtName
            // 
            txtName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(468, 231);
            txtName.Name = "txtName";
            txtName.Size = new Size(377, 30);
            txtName.TabIndex = 6;
            txtName.Text = "Enter Name";
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(468, 287);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(377, 30);
            txtAge.TabIndex = 6;
            txtAge.Text = "Enter Age";
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(1225, 345);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 86);
            txtAddress.TabIndex = 6;
            txtAddress.Text = "Enter Current Address";
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(469, 341);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(376, 34);
            cmbGender.TabIndex = 7;
            cmbGender.Text = "                              Select Your Gender";
            cmbGender.UseWaitCursor = true;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumber.Location = new Point(1225, 229);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(376, 30);
            txtContactNumber.TabIndex = 8;
            txtContactNumber.Text = "Enter Phone Number";
            txtContactNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(1225, 283);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 30);
            txtEmail.TabIndex = 8;
            txtEmail.Text = "Enter Your Email";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(309, 418);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(102, 24);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "UserName";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(309, 466);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 24);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(469, 411);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(376, 30);
            txtUserName.TabIndex = 9;
            txtUserName.Text = "Username For Login";
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(468, 459);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 30);
            txtPassword.TabIndex = 9;
            txtPassword.Text = "Create Strong Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(239, 498);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1476, 212);
            dataGridView1.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(1351, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(251, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save and Add Measurements";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ButtonHighlight;
            btnBack.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1225, 454);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 38);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1036, 65);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 4;
            label1.Text = "Assign Trainer";
            // 
            // cmbTrainer
            // 
            cmbTrainer.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Items.AddRange(new object[] { "" });
            cmbTrainer.Location = new Point(1225, 60);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(376, 34);
            cmbTrainer.TabIndex = 7;
            cmbTrainer.UseWaitCursor = true;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNumber);
            Controls.Add(cmbTrainer);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(label1);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblAddMember);
            Controls.Add(pictureBox18);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            Text = "AddMember";
            Load += AddMember_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddMember;
        private Label lblName;
        private PictureBox pictureBox18;
        private Label lblAge;
        private Label lblGender;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox textB3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private TextBox txtContactNumber;
        private TextBox txtEmail;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private DataGridView dataGridView1;
        private Button btnSave;
        private Button btnBack;
        private Label label1;
        private ComboBox cmbTrainer;
    }
}