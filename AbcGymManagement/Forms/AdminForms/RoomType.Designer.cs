namespace AbcGymManagement.Forms.AdminForms
{
    partial class RoomType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType));
            panel1 = new Panel();
            pictureBox14 = new PictureBox();
            lblHall = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            lblName = new Label();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            DGVRoomType = new DataGridView();
            pictureBox12 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVRoomType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox14);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 77;
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
            // lblHall
            // 
            lblHall.AutoSize = true;
            lblHall.BackColor = Color.FromArgb(64, 64, 64);
            lblHall.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHall.ForeColor = SystemColors.ButtonHighlight;
            lblHall.Location = new Point(421, 77);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(209, 48);
            lblHall.TabIndex = 75;
            lblHall.Text = "Room Type";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 76;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(437, 290);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(405, 31);
            txtDescription.TabIndex = 80;
            // 
            // txtName
            // 
            txtName.Location = new Point(437, 239);
            txtName.Name = "txtName";
            txtName.Size = new Size(405, 31);
            txtName.TabIndex = 81;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(294, 290);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 78;
            label2.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(293, 243);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 24);
            lblName.TabIndex = 79;
            lblName.Text = "Name";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(612, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 82;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(612, 347);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 83;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(730, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DGVRoomType
            // 
            DGVRoomType.AllowUserToDeleteRows = false;
            DGVRoomType.BackgroundColor = SystemColors.ButtonHighlight;
            DGVRoomType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVRoomType.Location = new Point(288, 453);
            DGVRoomType.Name = "DGVRoomType";
            DGVRoomType.RowHeadersWidth = 62;
            DGVRoomType.RowTemplate.Height = 33;
            DGVRoomType.Size = new Size(1425, 257);
            DGVRoomType.TabIndex = 85;
            DGVRoomType.CellContentClick += DGVRoomType_CellContentClick;
            DGVRoomType.MouseDoubleClick += DGVRoomType_MouseDoubleClick;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(1645, -1);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(68, 63);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 86;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // RoomType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(pictureBox12);
            Controls.Add(DGVRoomType);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(panel1);
            Controls.Add(lblHall);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomType";
            Text = "RoomTyoe";
            Load += RoomType_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVRoomType).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox14;
        private Label lblHall;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label2;
        private Label lblName;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView DGVRoomType;
        private PictureBox pictureBox12;
    }
}