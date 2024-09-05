namespace AbcGymManagement.Forms
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            lblAttendance = new Label();
            lblDate = new Label();
            lblMemberNamr = new Label();
            lblMemberName = new Label();
            cmbMember = new ComboBox();
            lblMembers = new Label();
            dateTimePicker1 = new DateTimePicker();
            DtpCheckin = new DateTimePicker();
            dtpCheckout = new DateTimePicker();
            lbltime = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnAddAttendace = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblAttendance
            // 
            lblAttendance.AutoSize = true;
            lblAttendance.BackColor = Color.FromArgb(64, 64, 64);
            lblAttendance.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAttendance.ForeColor = SystemColors.ButtonHighlight;
            lblAttendance.Location = new Point(420, 80);
            lblAttendance.Name = "lblAttendance";
            lblAttendance.Size = new Size(212, 48);
            lblAttendance.TabIndex = 18;
            lblAttendance.Text = "Attendance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDate.Location = new Point(338, 251);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(51, 24);
            lblDate.TabIndex = 22;
            lblDate.Text = "Date";
            // 
            // lblMemberNamr
            // 
            lblMemberNamr.AutoSize = true;
            lblMemberNamr.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberNamr.Location = new Point(1212, 145);
            lblMemberNamr.Name = "lblMemberNamr";
            lblMemberNamr.Size = new Size(0, 23);
            lblMemberNamr.TabIndex = 40;
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberName.Location = new Point(1213, 139);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(0, 28);
            lblMemberName.TabIndex = 39;
            // 
            // cmbMember
            // 
            cmbMember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(1182, 92);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(356, 34);
            cmbMember.TabIndex = 38;
            cmbMember.Text = "                           Select Member ID";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(1013, 95);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 37;
            lblMembers.Text = "Members";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(519, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(492, 31);
            dateTimePicker1.TabIndex = 41;
            // 
            // DtpCheckin
            // 
            DtpCheckin.Format = DateTimePickerFormat.Time;
            DtpCheckin.Location = new Point(513, 328);
            DtpCheckin.Name = "DtpCheckin";
            DtpCheckin.Size = new Size(236, 31);
            DtpCheckin.TabIndex = 42;
            // 
            // dtpCheckout
            // 
            dtpCheckout.Format = DateTimePickerFormat.Time;
            dtpCheckout.Location = new Point(775, 328);
            dtpCheckout.Name = "dtpCheckout";
            dtpCheckout.Size = new Size(236, 31);
            dtpCheckout.TabIndex = 42;
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbltime.Location = new Point(332, 335);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(57, 24);
            lbltime.TabIndex = 22;
            lbltime.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(513, 301);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 22;
            label1.Text = "Checkin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(775, 301);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 22;
            label2.Text = "Checkout";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 485);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1475, 225);
            dataGridView1.TabIndex = 43;
            // 
            // btnAddAttendace
            // 
            btnAddAttendace.BackColor = Color.FromArgb(64, 64, 64);
            btnAddAttendace.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAttendace.ForeColor = SystemColors.ButtonHighlight;
            btnAddAttendace.Location = new Point(788, 432);
            btnAddAttendace.Name = "btnAddAttendace";
            btnAddAttendace.Size = new Size(230, 34);
            btnAddAttendace.TabIndex = 44;
            btnAddAttendace.Text = "Add Atendance";
            btnAddAttendace.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(788, 392);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 45;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlLight;
            btnDelete.Location = new Point(906, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox6);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 49;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 48;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(7, 25);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(lblAttendance);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAddAttendace);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(dtpCheckout);
            Controls.Add(DtpCheckin);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblMemberNamr);
            Controls.Add(lblMemberName);
            Controls.Add(cmbMember);
            Controls.Add(lblMembers);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltime);
            Controls.Add(lblDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Attendance";
            Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAttendance;
        private Label lblDate;
        private Label lblMemberNamr;
        private Label lblMemberName;
        private ComboBox cmbMember;
        private Label lblMembers;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker DtpCheckin;
        private DateTimePicker dtpCheckout;
        private Label lbltime;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnAddAttendace;
        private Button btnEdit;
        private Button btnDelete;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox6;
    }
}