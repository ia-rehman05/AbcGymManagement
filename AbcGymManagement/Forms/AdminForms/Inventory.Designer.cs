namespace AbcGymManagement.Forms
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            lblPayment = new Label();
            lblHallNam = new Label();
            lblMemberName = new Label();
            cmbMember = new ComboBox();
            lblMembers = new Label();
            txtQuantity = new ComboBox();
            txtItemName = new TextBox();
            label1 = new Label();
            lblName = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            DGVMeasurement = new DataGridView();
            panel1 = new Panel();
            pictureBox15 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            SuspendLayout();
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.BackColor = Color.FromArgb(64, 64, 64);
            lblPayment.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPayment.ForeColor = SystemColors.ButtonHighlight;
            lblPayment.Location = new Point(432, 80);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(184, 48);
            lblPayment.TabIndex = 21;
            lblPayment.Text = "Inventory";
            // 
            // lblHallNam
            // 
            lblHallNam.AutoSize = true;
            lblHallNam.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblHallNam.Location = new Point(1201, 139);
            lblHallNam.Name = "lblHallNam";
            lblHallNam.Size = new Size(0, 23);
            lblHallNam.TabIndex = 55;
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberName.Location = new Point(1202, 133);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(0, 28);
            lblMemberName.TabIndex = 54;
            // 
            // cmbMember
            // 
            cmbMember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(1171, 86);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(406, 34);
            cmbMember.TabIndex = 53;
            cmbMember.Text = "                                  Select Hall ID";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(1002, 89);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(56, 24);
            lblMembers.TabIndex = 52;
            lblMembers.Text = "Halls";
            // 
            // txtQuantity
            // 
            txtQuantity.FormattingEnabled = true;
            txtQuantity.Items.AddRange(new object[] { "Aerobics Hall", "Weightlifting Hall", "Cardio Hall", "Sports Hall", "Multipurpose Hall", "Martial Arts Hall (Dojo)", "Swimming Pool Hall", "Yoga and Meditation Hall", "Spinning Hall", "CrossFit Hall" });
            txtQuantity.Location = new Point(517, 337);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(406, 33);
            txtQuantity.TabIndex = 59;
            txtQuantity.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(518, 280);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(405, 31);
            txtItemName.TabIndex = 58;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 342);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 56;
            label1.Text = "Quantity";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(289, 284);
            lblName.Name = "lblName";
            lblName.Size = new Size(108, 24);
            lblName.TabIndex = 57;
            lblName.Text = "Item Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(1221, 277);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 31);
            txtName.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(984, 341);
            label2.Name = "label2";
            label2.Size = new Size(218, 24);
            label2.TabIndex = 60;
            label2.Text = "Last Maintainance Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(984, 284);
            label3.Name = "label3";
            label3.Size = new Size(217, 24);
            label3.TabIndex = 61;
            label3.Text = "Maintainance Schedule";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1221, 336);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 31);
            dateTimePicker1.TabIndex = 63;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1347, 422);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 64;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(1347, 382);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 65;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1465, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 66;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // DGVMeasurement
            // 
            DGVMeasurement.AllowUserToDeleteRows = false;
            DGVMeasurement.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMeasurement.Location = new Point(288, 476);
            DGVMeasurement.Name = "DGVMeasurement";
            DGVMeasurement.RowHeadersWidth = 62;
            DGVMeasurement.RowTemplate.Height = 33;
            DGVMeasurement.Size = new Size(1426, 233);
            DGVMeasurement.TabIndex = 67;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox15);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 77;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(8, 22);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(43, 48);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 78;
            pictureBox15.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 76;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(panel1);
            Controls.Add(DGVMeasurement);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblHallNam);
            Controls.Add(lblMemberName);
            Controls.Add(cmbMember);
            Controls.Add(lblMembers);
            Controls.Add(lblPayment);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPayment;
        private Label lblHallNam;
        private Label lblMemberName;
        private ComboBox cmbMember;
        private Label lblMembers;
        private ComboBox txtQuantity;
        private TextBox txtItemName;
        private Label label1;
        private Label lblName;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView DGVMeasurement;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox15;
    }
}