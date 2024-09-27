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
            lblExit = new Label();
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
            lblAddMember.Location = new Point(326, 62);
            lblAddMember.Margin = new Padding(2, 0, 2, 0);
            lblAddMember.Name = "lblAddMember";
            lblAddMember.Size = new Size(204, 41);
            lblAddMember.TabIndex = 3;
            lblAddMember.Text = "Add Member";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(248, 159);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(91, 18);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(248, 231);
            lblAge.Margin = new Padding(2, 0, 2, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 18);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(247, 277);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(63, 18);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(814, 198);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 18);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(814, 242);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 4;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(413, 156);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(302, 26);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(413, 231);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(302, 26);
            txtAge.TabIndex = 3;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(979, 242);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(302, 70);
            txtAddress.TabIndex = 8;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(413, 271);
            cmbGender.Margin = new Padding(2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(302, 29);
            cmbGender.TabIndex = 4;
            cmbGender.UseWaitCursor = true;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(979, 193);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 26);
            txtEmail.TabIndex = 7;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(814, 150);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(83, 18);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(979, 146);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 26);
            txtPassword.TabIndex = 6;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // DGVMember
            // 
            DGVMember.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMember.Location = new Point(230, 432);
            DGVMember.Margin = new Padding(2);
            DGVMember.Name = "DGVMember";
            DGVMember.RowHeadersWidth = 62;
            DGVMember.RowTemplate.Height = 33;
            DGVMember.Size = new Size(1142, 136);
            DGVMember.TabIndex = 15;
            DGVMember.CellContentClick += DGVMember_CellContentClick;
            DGVMember.MouseDoubleClick += DGVMember_MouseDoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1079, 397);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 30);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save and Add Measurements";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(646, 66);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 4;
            label1.Text = "Assign Trainer";
            // 
            // cmbTrainer
            // 
            cmbTrainer.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTrainer.FormattingEnabled = true;
            cmbTrainer.Items.AddRange(new object[] { "" });
            cmbTrainer.Location = new Point(797, 62);
            cmbTrainer.Margin = new Padding(2);
            cmbTrainer.Name = "cmbTrainer";
            cmbTrainer.Size = new Size(163, 29);
            cmbTrainer.TabIndex = 13;
            cmbTrainer.UseWaitCursor = true;
            cmbTrainer.SelectedIndexChanged += cmbTrainer_SelectedIndexChanged;
            // 
            // lblTrainerName
            // 
            lblTrainerName.AutoSize = true;
            lblTrainerName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTrainerName.Location = new Point(798, 94);
            lblTrainerName.Margin = new Padding(2, 0, 2, 0);
            lblTrainerName.Name = "lblTrainerName";
            lblTrainerName.Size = new Size(0, 20);
            lblTrainerName.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(6, 19);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(233, 47);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 71);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(230, 47);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(47, 97);
            panel1.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(412, 194);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(302, 26);
            txtLastName.TabIndex = 2;
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(247, 197);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 19;
            label3.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(248, 323);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 18);
            label7.TabIndex = 21;
            label7.Text = "Date Of Birth";
            // 
            // DTPDOB
            // 
            DTPDOB.Location = new Point(413, 318);
            DTPDOB.Margin = new Padding(2);
            DTPDOB.Name = "DTPDOB";
            DTPDOB.Size = new Size(301, 27);
            DTPDOB.TabIndex = 5;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChkIsActive.Location = new Point(1195, 316);
            ChkIsActive.Margin = new Padding(2);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(87, 22);
            ChkIsActive.TabIndex = 9;
            ChkIsActive.TabStop = true;
            ChkIsActive.Text = "IsActive";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblMembershipName
            // 
            lblMembershipName.AutoSize = true;
            lblMembershipName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMembershipName.Location = new Point(1141, 94);
            lblMembershipName.Margin = new Padding(2, 0, 2, 0);
            lblMembershipName.Name = "lblMembershipName";
            lblMembershipName.Size = new Size(0, 20);
            lblMembershipName.TabIndex = 26;
            // 
            // cmbMembershipID
            // 
            cmbMembershipID.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMembershipID.FormattingEnabled = true;
            cmbMembershipID.Items.AddRange(new object[] { "" });
            cmbMembershipID.Location = new Point(1139, 62);
            cmbMembershipID.Margin = new Padding(2);
            cmbMembershipID.Name = "cmbMembershipID";
            cmbMembershipID.Size = new Size(170, 29);
            cmbMembershipID.TabIndex = 14;
            cmbMembershipID.UseWaitCursor = true;
            cmbMembershipID.SelectedIndexChanged += cmbMembershipID_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(988, 66);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(155, 18);
            label9.TabIndex = 24;
            label9.Text = "Assign Membership";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1079, 365);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 27);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(1182, 365);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 27);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblExit.Location = new Point(1337, 0);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(35, 38);
            lblExit.TabIndex = 29;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 568);
            Controls.Add(lblExit);
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
            Margin = new Padding(2);
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
        private Label lblExit;
    }
}