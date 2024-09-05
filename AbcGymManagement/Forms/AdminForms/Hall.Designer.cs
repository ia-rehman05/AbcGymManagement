namespace AbcGymManagement.Forms
{
    partial class Hall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hall));
            lblName = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtCapacity = new TextBox();
            txtLocation = new TextBox();
            DGVHall = new DataGridView();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label4 = new Label();
            ChkAvailible = new RadioButton();
            lblHall = new Label();
            panel1 = new Panel();
            pictureBox14 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            cmbRoomType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DGVHall).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(337, 256);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 49;
            lblName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(337, 372);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 49;
            label2.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(337, 424);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 49;
            label3.Text = "Location";
            // 
            // txtName
            // 
            txtName.Location = new Point(481, 252);
            txtName.Name = "txtName";
            txtName.Size = new Size(405, 31);
            txtName.TabIndex = 50;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(480, 372);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(405, 31);
            txtCapacity.TabIndex = 50;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(481, 420);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(405, 31);
            txtLocation.TabIndex = 50;
            // 
            // DGVHall
            // 
            DGVHall.AllowUserToDeleteRows = false;
            DGVHall.BackgroundColor = SystemColors.ButtonHighlight;
            DGVHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHall.Location = new Point(236, 543);
            DGVHall.Name = "DGVHall";
            DGVHall.RowHeadersWidth = 62;
            DGVHall.RowTemplate.Height = 33;
            DGVHall.Size = new Size(1477, 168);
            DGVHall.TabIndex = 61;
            DGVHall.CellContentClick += DGVMeasurement_CellContentClick;
            DGVHall.SelectionChanged += DGVHall_SelectionChanged;
            DGVHall.MouseDoubleClick += DGVHall_MouseDoubleClick;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(656, 503);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 67;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(656, 463);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 68;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(774, 463);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 69;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(337, 473);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
            label4.TabIndex = 70;
            label4.Text = "Avaliability";
            // 
            // ChkAvailible
            // 
            ChkAvailible.AutoSize = true;
            ChkAvailible.Location = new Point(481, 477);
            ChkAvailible.Name = "ChkAvailible";
            ChkAvailible.Size = new Size(21, 20);
            ChkAvailible.TabIndex = 71;
            ChkAvailible.TabStop = true;
            ChkAvailible.UseVisualStyleBackColor = true;
            // 
            // lblHall
            // 
            lblHall.AutoSize = true;
            lblHall.BackColor = Color.FromArgb(64, 64, 64);
            lblHall.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHall.ForeColor = SystemColors.ButtonHighlight;
            lblHall.Location = new Point(464, 80);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(87, 48);
            lblHall.TabIndex = 23;
            lblHall.Text = "Hall";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox14);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 74;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(7, 24);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(43, 48);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 75;
            pictureBox14.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 310);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 49;
            label1.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(481, 310);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(405, 34);
            cmbRoomType.TabIndex = 75;
            // 
            // Hall
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(cmbRoomType);
            Controls.Add(panel1);
            Controls.Add(ChkAvailible);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(DGVHall);
            Controls.Add(txtLocation);
            Controls.Add(txtCapacity);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblHall);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hall";
            Text = "Hall";
            Load += Hall_Load;
            ((System.ComponentModel.ISupportInitialize)DGVHall).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtCapacity;
        private TextBox txtLocation;
        private DataGridView DGVHall;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label label4;
        private RadioButton ChkAvailible;
        private Label lblHall;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox14;
        private Label label1;
        private ComboBox cmbRoomType;
    }
}