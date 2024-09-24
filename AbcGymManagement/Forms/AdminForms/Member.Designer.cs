namespace AbcGymManagement.Forms
{
    partial class Member
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
            lblAge = new Label();
            lblGender = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            DGVMember = new DataGridView();
            btnSave = new Button();
            label1 = new Label();
            cmbTrainer = new ComboBox();
            lblTrainerName = new Label();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            txtLastName = new TextBox();
            label3 = new Label();
            label7 = new Label();
            DTPDOB = new DateTimePicker();
            ChkIsActive = new RadioButton();
            lblMembershipName = new Label();
            cmbMembershipID = new ComboBox();
            label9 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVMember).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddMember
            // 
            lblAddMember.AutoSize = true;
            lblAddMember.BackColor = Color.FromArgb(64, 64, 64);
            lblAddMember.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddMember.ForeColor = SystemColors.ButtonHighlight;
            lblAddMember.Location = new Point(407, 78);
            lblAddMember.Name = "lblAddMember";
            lblAddMember.Size = new Size(240, 48);
            lblAddMember.TabIndex = 3;
            lblAddMember.Text = "Add Member";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(310, 199);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 24);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(310, 289);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 24);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(309, 346);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 24);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1017, 247);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1017, 303);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 4;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(516, 195);
            txtName.Name = "txtName";
            txtName.Size = new Size(377, 30);
            txtName.TabIndex = 6;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(516, 289);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(377, 30);
            txtAge.TabIndex = 6;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(1224, 303);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 86);
            txtAddress.TabIndex = 6;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(516, 339);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(376, 34);
            cmbGender.TabIndex = 7;
            cmbGender.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(1224, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 30);
            txtEmail.TabIndex = 8;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(1018, 187);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 24);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(1224, 182);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 30);
            txtPassword.TabIndex = 9;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // DGVMember
            // 
            DGVMember.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMember.Location = new Point(288, 540);
            DGVMember.Name = "DGVMember";
            DGVMember.RowHeadersWidth = 62;
            DGVMember.RowTemplate.Height = 33;
            DGVMember.Size = new Size(1427, 170);
            DGVMember.TabIndex = 10;
            DGVMember.CellContentClick += DGVMember_CellContentClick;
            DGVMember.MouseDoubleClick += DGVMember_MouseDoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1349, 496);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(251, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save and Add Measurements";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(807, 83);
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
            cmbTrainer.Location = new Point(996, 78);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(203, 34);
            cmbTrainer.TabIndex = 7;
            cmbTrainer.UseWaitCursor = true;
            cmbTrainer.SelectedIndexChanged += cmbTrainer_SelectedIndexChanged;
            // 
            // lblTrainerName
            // 
            lblTrainerName.AutoSize = true;
            lblTrainerName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrainerName.Location = new Point(998, 117);
            lblTrainerName.Name = "lblTrainerName";
            lblTrainerName.Size = new Size(0, 23);
            lblTrainerName.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(7, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(515, 242);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(377, 30);
            txtLastName.TabIndex = 20;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(309, 246);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 19;
            label3.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(310, 404);
            label7.Name = "label7";
            label7.Size = new Size(125, 24);
            label7.TabIndex = 21;
            label7.Text = "Date Of Birth";
            // 
            // DTPDOB
            // 
            DTPDOB.Location = new Point(516, 397);
            DTPDOB.Name = "DTPDOB";
            DTPDOB.Size = new Size(375, 31);
            DTPDOB.TabIndex = 22;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChkIsActive.Location = new Point(1494, 395);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(106, 28);
            ChkIsActive.TabIndex = 23;
            ChkIsActive.TabStop = true;
            ChkIsActive.Text = "IsActive";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblMembershipName
            // 
            lblMembershipName.AutoSize = true;
            lblMembershipName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMembershipName.Location = new Point(1426, 117);
            lblMembershipName.Name = "lblMembershipName";
            lblMembershipName.Size = new Size(0, 23);
            lblMembershipName.TabIndex = 26;
            // 
            // cmbMembershipID
            // 
            cmbMembershipID.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMembershipID.FormattingEnabled = true;
            cmbMembershipID.Items.AddRange(new object[] { "" });
            cmbMembershipID.Location = new Point(1424, 78);
            cmbMembershipID.Name = "cmbMembershipID";
            cmbMembershipID.Size = new Size(212, 34);
            cmbMembershipID.TabIndex = 25;
            cmbMembershipID.UseWaitCursor = true;
            cmbMembershipID.SelectedIndexChanged += cmbMembershipID_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1235, 83);
            label9.Name = "label9";
            label9.Size = new Size(187, 24);
            label9.TabIndex = 24;
            label9.Text = "Assign Membership";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1349, 456);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 34);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(1477, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 34);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblMembershipName);
            Controls.Add(cmbMembershipID);
            Controls.Add(label9);
            Controls.Add(ChkIsActive);
            Controls.Add(DTPDOB);
            Controls.Add(label7);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblTrainerName);
            Controls.Add(btnSave);
            Controls.Add(DGVMember);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(cmbTrainer);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(lblAddMember);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Member";
            Text = "AddMember";
            Load += AddMember_Load;
            ((System.ComponentModel.ISupportInitialize)DGVMember).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddMember;
        private Label lblName;
        private Label lblAge;
        private Label lblGender;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox textB3;
        private TextBox textBox4;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private DataGridView DGVMember;
        private Button btnSave;
        private Label label1;
        private ComboBox cmbTrainer;
        private Label lblTrainerName;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private TextBox txtLastName;
        private Label label3;
        private Label label7;
        private DateTimePicker DTPDOB;
        private RadioButton ChkIsActive;
        private Label lblMembershipName;
        private ComboBox cmbMembershipID;
        private Label label9;
        private Button btnEdit;
        private Button btnDelete;
    }
}