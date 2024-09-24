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
            DGVMembership = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lblMembers = new Label();
            lblMembership = new Label();
            cmbMember = new ComboBox();
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmbPackage = new ComboBox();
            label2 = new Label();
            ChkIsActive = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)DGVMembership).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGVMembership
            // 
            DGVMembership.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMembership.Location = new Point(290, 478);
            DGVMembership.Name = "DGVMembership";
            DGVMembership.RowHeadersWidth = 62;
            DGVMembership.RowTemplate.Height = 33;
            DGVMembership.Size = new Size(682, 231);
            DGVMembership.TabIndex = 30;
            DGVMembership.MouseDoubleClick += DGVMembership_MouseDoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(582, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 34);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(710, 370);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(582, 370);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(297, 233);
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
            // cmbMember
            // 
            cmbMember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(466, 230);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(356, 34);
            cmbMember.TabIndex = 34;
            cmbMember.Text = "                           Select Member ID";
            cmbMember.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 82;
            // 
            // cmbPackage
            // 
            cmbPackage.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(466, 279);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(356, 34);
            cmbPackage.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(297, 282);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 84;
            label2.Text = "Package";
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChkIsActive.Location = new Point(466, 332);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(106, 28);
            ChkIsActive.TabIndex = 110;
            ChkIsActive.TabStop = true;
            ChkIsActive.Text = "IsActive";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(971, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 650);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(ChkIsActive);
            Controls.Add(cmbPackage);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(cmbMember);
            Controls.Add(DGVMembership);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblMembers);
            Controls.Add(lblMembership);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Membership";
            Text = "Membership";
            Load += Membership_Load;
            ((System.ComponentModel.ISupportInitialize)DGVMembership).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVMembership;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Label lblMembers;
        private Label lblMembership;
        private ComboBox cmbMember;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox9;
        private ComboBox cmbPackage;
        private Label label2;
        private RadioButton ChkIsActive;
        private PictureBox pictureBox1;
    }
}