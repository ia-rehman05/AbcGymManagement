namespace AbcGymManagement.Forms.AdminForms
{
    partial class Package
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            panel1 = new Panel();
            pictureBox9 = new PictureBox();
            DTPEnd = new DateTimePicker();
            DTPStart = new DateTimePicker();
            txtDuration = new TextBox();
            txtAmout = new TextBox();
            DGVPackage = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label1 = new Label();
            label4 = new Label();
            lblPrice = new Label();
            lblDuration = new Label();
            lblName = new Label();
            lblMembership = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ChkIsActive = new RadioButton();
            txtName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVPackage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox9);
            panel1.Location = new Point(289, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 104;
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
            // DTPEnd
            // 
            DTPEnd.Location = new Point(1129, 271);
            DTPEnd.Name = "DTPEnd";
            DTPEnd.Size = new Size(300, 31);
            DTPEnd.TabIndex = 98;
            // 
            // DTPStart
            // 
            DTPStart.Location = new Point(1129, 218);
            DTPStart.Name = "DTPStart";
            DTPStart.Size = new Size(300, 31);
            DTPStart.TabIndex = 97;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(484, 314);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(335, 31);
            txtDuration.TabIndex = 95;
            // 
            // txtAmout
            // 
            txtAmout.Location = new Point(484, 260);
            txtAmout.Name = "txtAmout";
            txtAmout.Size = new Size(335, 31);
            txtAmout.TabIndex = 96;
            // 
            // DGVPackage
            // 
            DGVPackage.BackgroundColor = SystemColors.ButtonHighlight;
            DGVPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPackage.Location = new Point(292, 452);
            DGVPackage.Name = "DGVPackage";
            DGVPackage.RowHeadersWidth = 62;
            DGVPackage.RowTemplate.Height = 33;
            DGVPackage.Size = new Size(1421, 260);
            DGVPackage.TabIndex = 94;
            DGVPackage.CellContentClick += DGVPackage_CellContentClick;
            DGVPackage.DoubleClick += DGVPackage_DoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1189, 412);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 34);
            btnSave.TabIndex = 93;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1317, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 92;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(1189, 372);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 91;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(977, 221);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 86;
            label1.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(977, 280);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 85;
            label4.Text = "End Date";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(300, 262);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 24);
            lblPrice.TabIndex = 87;
            lblPrice.Text = "Amount";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuration.Location = new Point(300, 318);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(90, 24);
            lblDuration.TabIndex = 88;
            lblDuration.Text = "Duration";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(300, 208);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 89;
            lblName.Text = "Name";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.BackColor = Color.FromArgb(64, 64, 64);
            lblMembership.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembership.ForeColor = SystemColors.ButtonHighlight;
            lblMembership.Location = new Point(445, 51);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(157, 48);
            lblMembership.TabIndex = 84;
            lblMembership.Text = "Package";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(292, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 103;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ChkIsActive.Location = new Point(1129, 317);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(106, 28);
            ChkIsActive.TabIndex = 109;
            ChkIsActive.TabStop = true;
            ChkIsActive.Text = "IsActive";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(484, 201);
            txtName.Name = "txtName";
            txtName.Size = new Size(335, 31);
            txtName.TabIndex = 110;
            // 
            // Package
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(txtName);
            Controls.Add(ChkIsActive);
            Controls.Add(panel1);
            Controls.Add(DTPEnd);
            Controls.Add(DTPStart);
            Controls.Add(txtDuration);
            Controls.Add(txtAmout);
            Controls.Add(DGVPackage);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lblPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblName);
            Controls.Add(lblMembership);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Package";
            Text = "Package";
            Load += Package_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVPackage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox9;
        private ComboBox cmbScheme;
        private DateTimePicker DTPEnd;
        private DateTimePicker DTPStart;
        private TextBox txtDuration;
        private TextBox txtAmout;
        private DataGridView DGVPackage;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private Label label4;
        private Label lblPrice;
        private Label lblDuration;
        private Label lblName;
        private Label lblMembership;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton ChkIsActive;
        private TextBox txtName;
    }
}