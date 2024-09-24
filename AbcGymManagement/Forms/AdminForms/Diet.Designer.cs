namespace AbcGymManagement.Forms
{
    partial class Diet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diet));
            lblMembership = new Label();
            lblName = new Label();
            cmbMeatype = new ComboBox();
            label1 = new Label();
            lblCalories = new Label();
            txtCalories = new TextBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            lblMemberNamr = new Label();
            lblMemberName = new Label();
            cmbMembers = new ComboBox();
            lblMembers = new Label();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtFoodItem = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.BackColor = Color.FromArgb(64, 64, 64);
            lblMembership.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembership.ForeColor = SystemColors.ButtonHighlight;
            lblMembership.Location = new Point(474, 79);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(90, 48);
            lblMembership.TabIndex = 17;
            lblMembership.Text = "Diet";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(302, 244);
            lblName.Name = "lblName";
            lblName.Size = new Size(102, 24);
            lblName.TabIndex = 21;
            lblName.Text = "Meal Type";
            // 
            // cmbMeatype
            // 
            cmbMeatype.FormattingEnabled = true;
            cmbMeatype.Location = new Point(474, 241);
            cmbMeatype.Name = "cmbMeatype";
            cmbMeatype.Size = new Size(381, 33);
            cmbMeatype.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(302, 306);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 23;
            label1.Text = "Food Items";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalories.Location = new Point(934, 244);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(82, 24);
            lblCalories.TabIndex = 25;
            lblCalories.Text = "Calories";
            // 
            // txtCalories
            // 
            txtCalories.Location = new Point(1110, 244);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(335, 31);
            txtCalories.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1333, 334);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(1215, 334);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1215, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblMemberNamr
            // 
            lblMemberNamr.AutoSize = true;
            lblMemberNamr.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberNamr.Location = new Point(1140, 144);
            lblMemberNamr.Name = "lblMemberNamr";
            lblMemberNamr.Size = new Size(0, 23);
            lblMemberNamr.TabIndex = 40;
            // 
            // lblMemberName
            // 
            lblMemberName.AutoSize = true;
            lblMemberName.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMemberName.Location = new Point(1141, 138);
            lblMemberName.Name = "lblMemberName";
            lblMemberName.Size = new Size(0, 28);
            lblMemberName.TabIndex = 39;
            // 
            // cmbMembers
            // 
            cmbMembers.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(1110, 91);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(356, 34);
            cmbMembers.TabIndex = 38;
            cmbMembers.Text = "                           Select Member ID";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(941, 94);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 37;
            lblMembers.Text = "Members";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox7);
            panel1.Location = new Point(288, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 121);
            panel1.TabIndex = 52;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 27);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 53;
            pictureBox7.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 51;
            // 
            // txtFoodItem
            // 
            txtFoodItem.Location = new Point(474, 306);
            txtFoodItem.Name = "txtFoodItem";
            txtFoodItem.Size = new Size(381, 31);
            txtFoodItem.TabIndex = 53;
            // 
            // Diet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1713, 710);
            Controls.Add(txtFoodItem);
            Controls.Add(panel1);
            Controls.Add(lblMemberNamr);
            Controls.Add(lblMemberName);
            Controls.Add(cmbMembers);
            Controls.Add(lblMembers);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(txtCalories);
            Controls.Add(lblCalories);
            Controls.Add(label1);
            Controls.Add(cmbMeatype);
            Controls.Add(lblName);
            Controls.Add(lblMembership);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diet";
            Text = "Diet";
            Load += Diet_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMembership;
        private Label lblName;
        private ComboBox cmbMeatype;
        private Label label1;
        private Label lblCalories;
        private TextBox txtCalories;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSave;
        private Label lblMemberNamr;
        private Label lblMemberName;
        private ComboBox cmbMembers;
        private Label lblMembers;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox7;
        private TextBox txtFoodItem;
    }
}