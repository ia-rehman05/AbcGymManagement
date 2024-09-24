namespace AbcGymManagement.Forms
{
    partial class Measurement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measurement));
            lblAddMeasurements = new Label();
            lblMembers = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbMembers = new ComboBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            txtBodyFat = new TextBox();
            txtMuscleMass = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            DgvMeasurement = new DataGridView();
            panel1 = new Panel();
            pictureBox11 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DgvMeasurement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // lblAddMeasurements
            // 
            lblAddMeasurements.AutoSize = true;
            lblAddMeasurements.BackColor = Color.FromArgb(64, 64, 64);
            lblAddMeasurements.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddMeasurements.ForeColor = SystemColors.ButtonHighlight;
            lblAddMeasurements.Location = new Point(381, 81);
            lblAddMeasurements.Name = "lblAddMeasurements";
            lblAddMeasurements.Size = new Size(267, 48);
            lblAddMeasurements.TabIndex = 7;
            lblAddMeasurements.Text = "Measurements";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(905, 105);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 8;
            lblMembers.Text = "Members";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(302, 293);
            label1.Name = "label1";
            label1.Size = new Size(71, 24);
            label1.TabIndex = 8;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(302, 352);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 8;
            label2.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(898, 293);
            label3.Name = "label3";
            label3.Size = new Size(141, 24);
            label3.TabIndex = 8;
            label3.Text = "Body Fat %age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(898, 352);
            label4.Name = "label4";
            label4.Size = new Size(124, 24);
            label4.TabIndex = 8;
            label4.Text = "Muscle Mass";
            // 
            // cmbMembers
            // 
            cmbMembers.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(1044, 102);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(386, 34);
            cmbMembers.TabIndex = 9;
            cmbMembers.Tag = "";
            cmbMembers.Text = "                                   Select Member ID";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHeight.Location = new Point(442, 289);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(329, 30);
            txtHeight.TabIndex = 10;
            txtHeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWeight
            // 
            txtWeight.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtWeight.Location = new Point(442, 347);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(329, 30);
            txtWeight.TabIndex = 10;
            txtWeight.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBodyFat
            // 
            txtBodyFat.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBodyFat.Location = new Point(1101, 287);
            txtBodyFat.Name = "txtBodyFat";
            txtBodyFat.Size = new Size(329, 30);
            txtBodyFat.TabIndex = 10;
            txtBodyFat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMuscleMass
            // 
            txtMuscleMass.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMuscleMass.Location = new Point(1101, 346);
            txtMuscleMass.Name = "txtMuscleMass";
            txtMuscleMass.Size = new Size(329, 30);
            txtMuscleMass.TabIndex = 10;
            txtMuscleMass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(1190, 399);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1318, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1190, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(240, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // DgvMeasurement
            // 
            DgvMeasurement.BackgroundColor = SystemColors.ButtonHighlight;
            DgvMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMeasurement.Location = new Point(288, 479);
            DgvMeasurement.Name = "DgvMeasurement";
            DgvMeasurement.RowHeadersWidth = 62;
            DgvMeasurement.RowTemplate.Height = 33;
            DgvMeasurement.Size = new Size(1426, 231);
            DgvMeasurement.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox11);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 80;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(9, 22);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 48);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 81;
            pictureBox11.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 79;
            // 
            // Measurement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(panel1);
            Controls.Add(DgvMeasurement);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtWeight);
            Controls.Add(txtBodyFat);
            Controls.Add(txtMuscleMass);
            Controls.Add(txtHeight);
            Controls.Add(cmbMembers);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblMembers);
            Controls.Add(lblAddMeasurements);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Measurement";
            Text = "Measurement";
            Load += Measurement_Load;
            ((System.ComponentModel.ISupportInitialize)DgvMeasurement).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddMeasurements;
        private Label lblMembers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbMembers;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private TextBox txtBodyFat;
        private TextBox txtMuscleMass;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private DataGridView DgvMeasurement;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox11;
    }
}