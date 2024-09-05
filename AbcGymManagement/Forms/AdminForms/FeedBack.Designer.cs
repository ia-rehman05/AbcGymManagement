﻿namespace AbcGymManagement.Forms
{
    partial class FeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedBack));
            lblFeedabcl = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            lblMemberNamr = new Label();
            lblMemberName = new Label();
            cmbMember = new ComboBox();
            lblMembers = new Label();
            lblType = new Label();
            lblStatus = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            lblDrscription = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            DGVMeasurement = new DataGridView();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFeedabcl
            // 
            lblFeedabcl.AutoSize = true;
            lblFeedabcl.BackColor = Color.FromArgb(64, 64, 64);
            lblFeedabcl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFeedabcl.ForeColor = SystemColors.ButtonHighlight;
            lblFeedabcl.Location = new Point(428, 78);
            lblFeedabcl.Name = "lblFeedabcl";
            lblFeedabcl.Size = new Size(177, 48);
            lblFeedabcl.TabIndex = 19;
            lblFeedabcl.Text = "Feedback";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(562, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 31);
            dateTimePicker1.TabIndex = 43;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(326, 250);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(51, 24);
            lblDate.TabIndex = 42;
            lblDate.Text = "Date";
            // 
            // lblMemberNamr
            // 
            lblMemberNamr.AutoSize = true;
            lblMemberNamr.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberNamr.Location = new Point(1209, 147);
            lblMemberNamr.Name = "lblMemberNamr";
            lblMemberNamr.Size = new Size(0, 23);
            lblMemberNamr.TabIndex = 47;
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberName.Location = new Point(1210, 141);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(0, 28);
            lblMemberName.TabIndex = 46;
            // 
            // cmbMember
            // 
            cmbMember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(1179, 94);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(356, 34);
            cmbMember.TabIndex = 45;
            cmbMember.Text = "                           Select Member ID";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(1010, 97);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 44;
            lblMembers.Text = "Members";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblType.Location = new Point(326, 311);
            lblType.Name = "lblType";
            lblType.Size = new Size(141, 24);
            lblType.TabIndex = 42;
            lblType.Text = "Feedback Type";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(326, 366);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(167, 24);
            lblStatus.TabIndex = 42;
            lblStatus.Text = "Resolution Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Complaint", "Suggestion", "Praise" });
            comboBox1.Location = new Point(560, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 33);
            comboBox1.TabIndex = 48;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Pending ", "Resolved", "In Progress" });
            comboBox2.Location = new Point(560, 362);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(326, 33);
            comboBox2.TabIndex = 48;
            // 
            // lblDrscription
            // 
            lblDrscription.AutoSize = true;
            lblDrscription.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDrscription.Location = new Point(979, 244);
            lblDrscription.Name = "lblDrscription";
            lblDrscription.Size = new Size(113, 24);
            lblDrscription.TabIndex = 42;
            lblDrscription.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1179, 229);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 166);
            textBox1.TabIndex = 49;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1305, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(1305, 414);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 51;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1423, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DGVMeasurement
            // 
            DGVMeasurement.AllowUserToDeleteRows = false;
            DGVMeasurement.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMeasurement.Location = new Point(235, 490);
            DGVMeasurement.Name = "DGVMeasurement";
            DGVMeasurement.RowHeadersWidth = 62;
            DGVMeasurement.RowTemplate.Height = 33;
            DGVMeasurement.Size = new Size(1477, 219);
            DGVMeasurement.TabIndex = 53;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 56;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 55;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FeedBack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(panel1);
            Controls.Add(DGVMeasurement);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblMemberNamr);
            Controls.Add(lblMemberName);
            Controls.Add(cmbMember);
            Controls.Add(lblMembers);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblStatus);
            Controls.Add(lblDrscription);
            Controls.Add(lblType);
            Controls.Add(lblDate);
            Controls.Add(lblFeedabcl);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FeedBack";
            Text = "FeedBack";
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFeedabcl;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private Label lblMemberNamr;
        private Label lblMemberName;
        private ComboBox cmbMember;
        private Label lblMembers;
        private Label lblType;
        private Label lblStatus;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblDrscription;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView DGVMeasurement;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
    }
}