namespace AbcGymManagement.Forms
{
    partial class Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membership));
            DGVMeasurement = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label4 = new Label();
            lblPrice = new Label();
            lblDuration = new Label();
            lblName = new Label();
            lblMembers = new Label();
            lblMembership = new Label();
            label1 = new Label();
            txtAmout = new TextBox();
            txtDuration = new TextBox();
            DTPStart = new DateTimePicker();
            DTPEnd = new DateTimePicker();
            cmbScheme = new ComboBox();
            comboBox2 = new ComboBox();
            lblMemberName = new Label();
            lblMemberNamr = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // DGVMeasurement
            // 
            DGVMeasurement.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMeasurement.Location = new Point(235, 478);
            DGVMeasurement.Name = "DGVMeasurement";
            DGVMeasurement.RowHeadersWidth = 62;
            DGVMeasurement.RowTemplate.Height = 33;
            DGVMeasurement.Size = new Size(1477, 231);
            DGVMeasurement.TabIndex = 30;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1188, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 34);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1316, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(1188, 398);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(976, 355);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 17;
            label4.Text = "End Date";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(300, 346);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 24);
            lblPrice.TabIndex = 18;
            lblPrice.Text = "Amount";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.Location = new Point(300, 402);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(90, 24);
            lblDuration.TabIndex = 19;
            lblDuration.Text = "Duration";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(300, 292);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 24);
            lblName.TabIndex = 20;
            lblName.Text = "Scheme Name";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(903, 104);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 21;
            lblMembers.Text = "Members";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.BackColor = Color.FromArgb(64, 64, 64);
            lblMembership.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembership.ForeColor = SystemColors.ButtonHighlight;
            lblMembership.Location = new Point(385, 83);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(231, 48);
            lblMembership.TabIndex = 16;
            lblMembership.Text = "Membership";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(976, 296);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 17;
            label1.Text = "Start Date";
            // 
            // txtAmout
            // 
            txtAmout.Location = new Point(484, 344);
            txtAmout.Name = "txtAmout";
            txtAmout.Size = new Size(335, 31);
            txtAmout.TabIndex = 31;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(484, 398);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(335, 31);
            txtDuration.TabIndex = 31;
            // 
            // DTPStart
            // 
            DTPStart.Location = new Point(1128, 293);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(300, 31);
            DTPStart.TabIndex = 32;
            // 
            // DTPEnd
            // 
            DTPEnd.Location = new Point(1128, 346);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(300, 31);
            DTPEnd.TabIndex = 32;
            // 
            // cmbScheme
            // 
            cmbScheme.FormattingEnabled = true;
            cmbScheme.Location = new Point(483, 295);
            cmbScheme.Name = "cmbScheme";
            cmbScheme.Size = new Size(336, 33);
            cmbScheme.TabIndex = 33;
            cmbScheme.SelectedIndexChanged += cmbScheme_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1072, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(356, 34);
            comboBox2.TabIndex = 34;
            comboBox2.Text = "                           Select Member ID";
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberName.Location = new Point(1103, 148);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(0, 28);
            lblMemberName.TabIndex = 35;
            lblMemberName.Click += lblMemberName_Click;
            // 
            // lblMemberNamr
            // 
            lblMemberNamr.AutoSize = true;
            lblMemberNamr.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberNamr.Location = new Point(1102, 154);
            lblMemberNamr.Name = "lblMemberNamr";
            lblMemberNamr.Size = new Size(0, 23);
            lblMemberNamr.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox9);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 83;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 82;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(7, 24);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 84;
            pictureBox9.TabStop = false;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(panel1);
            Controls.Add(lblMemberNamr);
            Controls.Add(lblMemberName);
            Controls.Add(comboBox2);
            Controls.Add(cmbScheme);
            Controls.Add(DTPEnd);
            Controls.Add(DTPStart);
            Controls.Add(txtDuration);
            Controls.Add(txtAmout);
            Controls.Add(DGVMeasurement);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblName);
            Controls.Add(lblMembers);
            Controls.Add(lblMembership);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Membership";
            Text = "Membership";
            Load += Membership_Load;
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVMeasurement;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Label label4;
        private Label lblPrice;
        private Label lblDuration;
        private Label lblName;
        private Label lblMembers;
        private Label lblMembership;
        private Label label1;
        private TextBox txtAmout;
        private TextBox txtDuration;
        private DateTimePicker DTPStart;
        private DateTimePicker DTPEnd;
        private ComboBox cmbScheme;
        private ComboBox comboBox2;
        private Label lblMemberName;
        private Label lblMemberNamr;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox9;
    }
}