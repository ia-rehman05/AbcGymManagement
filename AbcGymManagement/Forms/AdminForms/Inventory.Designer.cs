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
            cmbHall = new ComboBox();
            lblMembers = new Label();
            txtQuantity = new ComboBox();
            txtItemName = new TextBox();
            label1 = new Label();
            lblName = new Label();
            txtSchedule = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpLastMainatainanace = new DateTimePicker();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            DGVInventory = new DataGridView();
            panel1 = new Panel();
            pictureBox15 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dtpNextMaintainanceDate = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVInventory).BeginInit();
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
            // cmbHall
            // 
            cmbHall.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbHall.FormattingEnabled = true;
            cmbHall.Location = new Point(1171, 86);
            cmbHall.Name = "cmbHall";
            cmbHall.Size = new Size(406, 34);
            cmbHall.TabIndex = 53;
            cmbHall.Text = "                                  Select Hall ID";
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
            txtQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
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
            // txtSchedule
            // 
            txtSchedule.Location = new Point(1212, 212);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(356, 31);
            txtSchedule.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(975, 276);
            label2.Name = "label2";
            label2.Size = new Size(218, 24);
            label2.TabIndex = 60;
            label2.Text = "Last Maintainance Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(975, 219);
            label3.Name = "label3";
            label3.Size = new Size(217, 24);
            label3.TabIndex = 61;
            label3.Text = "Maintainance Schedule";
            // 
            // dtpLastMainatainanace
            // 
            dtpLastMainatainanace.Location = new Point(1212, 271);
            dtpLastMainatainanace.Name = "dtpLastMainatainanace";
            dtpLastMainatainanace.Size = new Size(356, 31);
            dtpLastMainatainanace.TabIndex = 63;
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
            btnSave.Click += btnSave_Click;
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
            btnEdit.Click += btnEdit_Click;
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
            btnDelete.Click += btnDelete_Click;
            // 
            // DGVInventory
            // 
            DGVInventory.AllowUserToDeleteRows = false;
            DGVInventory.BackgroundColor = SystemColors.ButtonHighlight;
            DGVInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVInventory.Location = new Point(288, 476);
            DGVInventory.Name = "DGVInventory";
            DGVInventory.RowHeadersWidth = 62;
            DGVInventory.RowTemplate.Height = 33;
            DGVInventory.Size = new Size(1426, 233);
            DGVInventory.TabIndex = 67;
            DGVInventory.MouseDoubleClick += DGVInventory_MouseDoubleClick;
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
            // dtpNextMaintainanceDate
            // 
            dtpNextMaintainanceDate.Location = new Point(1212, 323);
            dtpNextMaintainanceDate.Name = "dtpNextMaintainanceDate";
            dtpNextMaintainanceDate.Size = new Size(356, 31);
            dtpNextMaintainanceDate.TabIndex = 79;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(975, 328);
            label4.Name = "label4";
            label4.Size = new Size(223, 24);
            label4.TabIndex = 78;
            label4.Text = "Next Maintainance Date";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(dtpNextMaintainanceDate);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(DGVInventory);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dtpLastMainatainanace);
            Controls.Add(txtSchedule);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblHallNam);
            Controls.Add(lblMemberName);
            Controls.Add(cmbHall);
            Controls.Add(lblMembers);
            Controls.Add(lblPayment);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)DGVInventory).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPayment;
        private Label lblHallNam;
        private Label lblMemberName;
        private ComboBox cmbHall;
        private Label lblMembers;
        private ComboBox txtQuantity;
        private TextBox txtItemName;
        private Label label1;
        private Label lblName;
        private TextBox txtSchedule;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpLastMainatainanace;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView DGVInventory;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox15;
        private DateTimePicker dtpNextMaintainanceDate;
        private Label label4;
    }
}