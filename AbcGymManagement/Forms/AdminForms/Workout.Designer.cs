namespace AbcGymManagement.Forms
{
    partial class Workout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workout));
            cmbmember = new ComboBox();
            txtExercise = new TextBox();
            DgvWorkout = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            lblReps = new Label();
            lblDay = new Label();
            lblMembers = new Label();
            lblMembership = new Label();
            txtSets = new TextBox();
            txtReps = new TextBox();
            labelMemberName = new Label();
            cmbDay = new ComboBox();
            lblSet = new Label();
            lblExercise = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DgvWorkout).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // cmbmember
            // 
            cmbmember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbmember.FormattingEnabled = true;
            cmbmember.Location = new Point(1072, 101);
            cmbmember.Name = "cmbmember";
            cmbmember.Size = new Size(356, 34);
            cmbmember.TabIndex = 54;
            cmbmember.Text = "                           Select Member ID";
            // 
            // txtExercise
            // 
            txtExercise.Location = new Point(484, 344);
            txtExercise.Name = "txtExercise";
            txtExercise.Size = new Size(335, 31);
            txtExercise.TabIndex = 49;
            // 
            // DgvWorkout
            // 
            DgvWorkout.BackgroundColor = SystemColors.ButtonHighlight;
            DgvWorkout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvWorkout.Location = new Point(235, 478);
            DgvWorkout.Name = "DgvWorkout";
            DgvWorkout.RowHeadersWidth = 62;
            DgvWorkout.RowTemplate.Height = 33;
            DgvWorkout.Size = new Size(1477, 231);
            DgvWorkout.TabIndex = 48;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(1188, 438);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1306, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 46;
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
            btnEdit.TabIndex = 45;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblReps
            // 
            lblReps.AutoSize = true;
            lblReps.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblReps.Location = new Point(976, 355);
            lblReps.Name = "lblReps";
            lblReps.Size = new Size(53, 24);
            lblReps.TabIndex = 39;
            lblReps.Text = "Reps";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(300, 292);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(44, 24);
            lblDay.TabIndex = 43;
            lblDay.Text = "Day";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(903, 104);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(94, 24);
            lblMembers.TabIndex = 44;
            lblMembers.Text = "Members";
            // 
            // lblMembership
            // 
            lblMembership.AutoSize = true;
            lblMembership.BackColor = Color.FromArgb(64, 64, 64);
            lblMembership.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembership.ForeColor = SystemColors.ButtonHighlight;
            lblMembership.Location = new Point(429, 81);
            lblMembership.Name = "lblMembership";
            lblMembership.Size = new Size(168, 48);
            lblMembership.TabIndex = 38;
            lblMembership.Text = "Workout";
            // 
            // txtSets
            // 
            txtSets.Location = new Point(1072, 292);
            txtSets.Name = "txtSets";
            txtSets.Size = new Size(346, 31);
            txtSets.TabIndex = 55;
            // 
            // txtReps
            // 
            txtReps.Location = new Point(1072, 344);
            txtReps.Name = "txtReps";
            txtReps.Size = new Size(346, 31);
            txtReps.TabIndex = 56;
            txtReps.TextChanged += textBox2_TextChanged;
            // 
            // labelMemberName
            // 
            labelMemberName.AutoSize = true;
            labelMemberName.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelMemberName.Location = new Point(1078, 140);
            labelMemberName.Name = "labelMemberName";
            labelMemberName.Size = new Size(0, 23);
            labelMemberName.TabIndex = 57;
            // 
            // cmbDay
            // 
            cmbDay.FormattingEnabled = true;
            cmbDay.Location = new Point(484, 287);
            cmbDay.Name = "cmbDay";
            cmbDay.Size = new Size(335, 33);
            cmbDay.TabIndex = 58;
            // 
            // lblSet
            // 
            lblSet.AutoSize = true;
            lblSet.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSet.Location = new Point(976, 291);
            lblSet.Name = "lblSet";
            lblSet.Size = new Size(38, 24);
            lblSet.TabIndex = 59;
            lblSet.Text = "Set";
            // 
            // lblExercise
            // 
            lblExercise.AutoSize = true;
            lblExercise.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblExercise.Location = new Point(300, 355);
            lblExercise.Name = "lblExercise";
            lblExercise.Size = new Size(85, 24);
            lblExercise.TabIndex = 60;
            lblExercise.Text = "Exercise";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox8);
            panel2.Location = new Point(288, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 121);
            panel2.TabIndex = 92;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(8, 28);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 48);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 93;
            pictureBox8.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // Workout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 709);
            Controls.Add(panel2);
            Controls.Add(lblExercise);
            Controls.Add(lblSet);
            Controls.Add(cmbDay);
            Controls.Add(labelMemberName);
            Controls.Add(txtReps);
            Controls.Add(txtSets);
            Controls.Add(cmbmember);
            Controls.Add(txtExercise);
            Controls.Add(DgvWorkout);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblReps);
            Controls.Add(lblDay);
            Controls.Add(lblMembers);
            Controls.Add(lblMembership);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Workout";
            Text = "Workout";
            Load += Workout_Load;
            ((System.ComponentModel.ISupportInitialize)DgvWorkout).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMemberNamr;
        private Label lblMemberName;
        private ComboBox cmbmember;
        private ComboBox cmbScheme;
        private DateTimePicker DTPEnd;
        private DateTimePicker DTPStart;
        private TextBox txtDuration;
        private TextBox txtExercise;
        private DataGridView DgvWorkout;
        private Button btnSave;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private Label lblReps;
        private Label lblPrice;
        private Label lblDuration;
        private Label lblDay;
        private Label lblMembers;
        private Label lblMembership;
        private TextBox txtSets;
        private TextBox txtReps;
        private Label labelMemberName;
        private ComboBox cmbDay;
        private Label lblSet;
        private Label lblExercise;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox8;
    }
}