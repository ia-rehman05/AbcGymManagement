namespace AbcGymManagement.Forms
{
    partial class Trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trainer));
            lblTrainer = new Label();
            lblSpecialization = new Label();
            cmbSpecialization = new ComboBox();
            cmbSchedule = new ComboBox();
            lblSchedule = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddRecord = new Button();
            panel2 = new Panel();
            pictureBox10 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ChkIsActive = new RadioButton();
            DTPDOB = new DateTimePicker();
            label7 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            cmbGender = new ComboBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblPassword = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtExperince = new TextBox();
            lblExperience = new Label();
            txtShift = new TextBox();
            lblShift = new Label();
            DGVTrainer = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVTrainer).BeginInit();
            SuspendLayout();
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.BackColor = Color.FromArgb(64, 64, 64);
            lblTrainer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrainer.ForeColor = SystemColors.ButtonHighlight;
            lblTrainer.Location = new Point(448, 80);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(136, 48);
            lblTrainer.TabIndex = 8;
            lblTrainer.Text = "Trainer";
            // 
            // lblSpecialization
            // 
            lblSpecialization.AutoSize = true;
            lblSpecialization.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpecialization.Location = new Point(1004, 264);
            lblSpecialization.Name = "lblSpecialization";
            lblSpecialization.Size = new Size(135, 24);
            lblSpecialization.TabIndex = 9;
            lblSpecialization.Text = "Specialization";
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Items.AddRange(new object[] { "Weght Lifting", "Swimming" });
            cmbSpecialization.Location = new Point(1201, 260);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(377, 33);
            cmbSpecialization.TabIndex = 10;
            // 
            // cmbSchedule
            // 
            cmbSchedule.FormattingEnabled = true;
            cmbSchedule.Items.AddRange(new object[] { "6 am to 10 am", "6 pm to 10 pm" });
            cmbSchedule.Location = new Point(1202, 367);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Size = new Size(377, 33);
            cmbSchedule.TabIndex = 12;
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSchedule.Location = new Point(1000, 376);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(91, 24);
            lblSchedule.TabIndex = 13;
            lblSchedule.Text = "Schedule";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(1448, 492);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1330, 492);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddRecord
            // 
            btnAddRecord.BackColor = Color.FromArgb(64, 64, 64);
            btnAddRecord.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRecord.ForeColor = SystemColors.ButtonHighlight;
            btnAddRecord.Location = new Point(1330, 539);
            btnAddRecord.Name = "btnAddRecord";
            btnAddRecord.Size = new Size(230, 34);
            btnAddRecord.TabIndex = 15;
            btnAddRecord.Text = "Add Record";
            btnAddRecord.UseVisualStyleBackColor = false;
            btnAddRecord.Click += btnAddRecord_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox10);
            panel2.Location = new Point(288, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 121);
            panel2.TabIndex = 89;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(8, 24);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 48);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 90;
            pictureBox10.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 88;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChkIsActive.Location = new Point(1202, 468);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(106, 28);
            ChkIsActive.TabIndex = 108;
            ChkIsActive.TabStop = true;
            ChkIsActive.Text = "IsActive";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // DTPDOB
            // 
            DTPDOB.Location = new Point(499, 398);
            DTPDOB.Name = "DTPDOB";
            DTPDOB.Size = new Size(375, 31);
            DTPDOB.TabIndex = 107;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(293, 405);
            label7.Name = "label7";
            label7.Size = new Size(125, 24);
            label7.TabIndex = 106;
            label7.Text = "Date Of Birth";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(498, 243);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(377, 30);
            txtLastName.TabIndex = 105;
            txtLastName.Text = "Enter Last Name";
            txtLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(292, 247);
            label3.Name = "label3";
            label3.Size = new Size(103, 24);
            label3.TabIndex = 104;
            label3.Text = "Last Name";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(498, 452);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 30);
            txtPassword.TabIndex = 103;
            txtPassword.Text = "Create Strong Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(1202, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 30);
            txtEmail.TabIndex = 102;
            txtEmail.Text = "Enter Your Email";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumber.Location = new Point(500, 509);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(376, 30);
            txtContactNumber.TabIndex = 101;
            txtContactNumber.Text = "Enter Phone Number";
            txtContactNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male ", "Female" });
            cmbGender.Location = new Point(499, 340);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(376, 34);
            cmbGender.TabIndex = 100;
            cmbGender.Text = "                              Select Your Gender";
            cmbGender.UseWaitCursor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(1201, 161);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 86);
            txtAddress.TabIndex = 99;
            txtAddress.Text = "Enter Current Address";
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(499, 290);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(377, 30);
            txtAge.TabIndex = 98;
            txtAge.Text = "Enter Age";
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(499, 196);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(377, 30);
            txtFirstName.TabIndex = 97;
            txtFirstName.Text = "Enter First Name";
            txtFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(994, 161);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 95;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(995, 113);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 94;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(293, 515);
            label4.Name = "label4";
            label4.Size = new Size(155, 24);
            label4.TabIndex = 93;
            label4.Text = "Contact Number";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(292, 457);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 24);
            lblPassword.TabIndex = 92;
            lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.Location = new Point(292, 347);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 24);
            lblGender.TabIndex = 91;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(293, 290);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(44, 24);
            lblAge.TabIndex = 96;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(293, 200);
            lblName.Name = "lblName";
            lblName.Size = new Size(107, 24);
            lblName.TabIndex = 90;
            lblName.Text = "First Name";
            // 
            // txtExperince
            // 
            txtExperince.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtExperince.Location = new Point(1202, 422);
            txtExperince.Name = "txtExperince";
            txtExperince.Size = new Size(376, 30);
            txtExperince.TabIndex = 110;
            txtExperince.TextAlign = HorizontalAlignment.Center;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExperience.Location = new Point(1000, 422);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(109, 24);
            lblExperience.TabIndex = 109;
            lblExperience.Text = "Experience";
            // 
            // txtShift
            // 
            txtShift.AcceptsReturn = true;
            txtShift.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtShift.Location = new Point(1202, 316);
            txtShift.Name = "txtShift";
            txtShift.Size = new Size(376, 30);
            txtShift.TabIndex = 112;
            txtShift.TextAlign = HorizontalAlignment.Center;
            // 
            // lblShift
            // 
            lblShift.AutoSize = true;
            lblShift.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblShift.Location = new Point(1004, 321);
            lblShift.Name = "lblShift";
            lblShift.Size = new Size(53, 24);
            lblShift.TabIndex = 111;
            lblShift.Text = "Shift";
            // 
            // DGVTrainer
            // 
            DGVTrainer.AllowUserToDeleteRows = false;
            DGVTrainer.BackgroundColor = SystemColors.ButtonHighlight;
            DGVTrainer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVTrainer.Location = new Point(235, 579);
            DGVTrainer.Name = "DGVTrainer";
            DGVTrainer.RowHeadersWidth = 62;
            DGVTrainer.RowTemplate.Height = 33;
            DGVTrainer.Size = new Size(1477, 162);
            DGVTrainer.TabIndex = 113;
            // 
            // Trainer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 740);
            Controls.Add(DGVTrainer);
            Controls.Add(txtShift);
            Controls.Add(lblShift);
            Controls.Add(txtExperince);
            Controls.Add(lblExperience);
            Controls.Add(ChkIsActive);
            Controls.Add(DTPDOB);
            Controls.Add(label7);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNumber);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPassword);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(panel2);
            Controls.Add(btnAddRecord);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(lblSchedule);
            Controls.Add(cmbSchedule);
            Controls.Add(cmbSpecialization);
            Controls.Add(lblSpecialization);
            Controls.Add(lblTrainer);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Trainer";
            Text = "Trainer";
            Load += Trainer_Load_1;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVTrainer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTrainer;
        private Label lblSpecialization;
        private ComboBox cmbSpecialization;
        private ComboBox cmbSchedule;
        private Label lblSchedule;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddRecord;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox10;
        private RadioButton ChkIsActive;
        private DateTimePicker DTPDOB;
        private Label label7;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtContactNumber;
        private ComboBox cmbGender;
        private TextBox txtAddress;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblPassword;
        private Label lblGender;
        private Label lblAge;
        private Label lblName;
        private TextBox txtExperince;
        private Label lblExperience;
        private TextBox txtShift;
        private Label lblShift;
        private DataGridView DGVTrainer;
    }
}