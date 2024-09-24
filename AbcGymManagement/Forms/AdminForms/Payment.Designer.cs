namespace AbcGymManagement.Forms
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            lblPayment = new Label();
            lblAmount = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblPayMethod = new Label();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            lblFatBurnPrice = new Label();
            lblMassGainerPrice = new Label();
            lblCreatinePrice = new Label();
            lblVitaminPrice = new Label();
            lblPreWorkoutPrice = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblProteinPrice = new Label();
            lblLogin = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            DGVMeasurement = new DataGridView();
            lblMembers = new Label();
            cmbMember = new ComboBox();
            lblPaidAmount = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel2 = new Panel();
            pictureBox13 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cmbPackage = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            DtpPaymentDate = new DateTimePicker();
            cmbPaymentStatus = new ComboBox();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.BackColor = Color.FromArgb(64, 64, 64);
            lblPayment.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPayment.ForeColor = SystemColors.ButtonHighlight;
            lblPayment.Location = new Point(429, 80);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(167, 48);
            lblPayment.TabIndex = 20;
            lblPayment.Text = "Payment";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmount.Location = new Point(1006, 154);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(134, 24);
            lblAmount.TabIndex = 52;
            lblAmount.Text = "Total Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1237, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 53;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(1296, 502);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 34);
            btnSave.TabIndex = 55;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(64, 64, 64);
            btnEdit.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(1296, 462);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 56;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1414, 462);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblPayMethod
            // 
            lblPayMethod.AutoSize = true;
            lblPayMethod.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPayMethod.Location = new Point(1006, 322);
            lblPayMethod.Name = "lblPayMethod";
            lblPayMethod.Size = new Size(162, 24);
            lblPayMethod.TabIndex = 52;
            lblPayMethod.Text = "Payment Method";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Card", "Cash" });
            comboBox1.Location = new Point(1237, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 33);
            comboBox1.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFatBurnPrice);
            panel1.Controls.Add(lblMassGainerPrice);
            panel1.Controls.Add(lblCreatinePrice);
            panel1.Controls.Add(lblVitaminPrice);
            panel1.Controls.Add(lblPreWorkoutPrice);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblProteinPrice);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(289, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 291);
            panel1.TabIndex = 59;
            // 
            // lblFatBurnPrice
            // 
            lblFatBurnPrice.AutoSize = true;
            lblFatBurnPrice.BackColor = SystemColors.Control;
            lblFatBurnPrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFatBurnPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblFatBurnPrice.Location = new Point(609, 98);
            lblFatBurnPrice.Name = "lblFatBurnPrice";
            lblFatBurnPrice.Size = new Size(85, 24);
            lblFatBurnPrice.TabIndex = 87;
            lblFatBurnPrice.Text = "Rs 4000";
            // 
            // lblMassGainerPrice
            // 
            lblMassGainerPrice.AutoSize = true;
            lblMassGainerPrice.BackColor = SystemColors.Control;
            lblMassGainerPrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMassGainerPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblMassGainerPrice.Location = new Point(608, 251);
            lblMassGainerPrice.Name = "lblMassGainerPrice";
            lblMassGainerPrice.Size = new Size(85, 24);
            lblMassGainerPrice.TabIndex = 88;
            lblMassGainerPrice.Text = "Rs 3000";
            // 
            // lblCreatinePrice
            // 
            lblCreatinePrice.AutoSize = true;
            lblCreatinePrice.BackColor = SystemColors.Control;
            lblCreatinePrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCreatinePrice.ForeColor = SystemColors.ActiveCaptionText;
            lblCreatinePrice.Location = new Point(364, 251);
            lblCreatinePrice.Name = "lblCreatinePrice";
            lblCreatinePrice.Size = new Size(85, 24);
            lblCreatinePrice.TabIndex = 89;
            lblCreatinePrice.Text = "Rs 3500";
            // 
            // lblVitaminPrice
            // 
            lblVitaminPrice.AutoSize = true;
            lblVitaminPrice.BackColor = SystemColors.Control;
            lblVitaminPrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblVitaminPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblVitaminPrice.Location = new Point(114, 251);
            lblVitaminPrice.Name = "lblVitaminPrice";
            lblVitaminPrice.Size = new Size(85, 24);
            lblVitaminPrice.TabIndex = 90;
            lblVitaminPrice.Text = "Rs 2200";
            // 
            // lblPreWorkoutPrice
            // 
            lblPreWorkoutPrice.AutoSize = true;
            lblPreWorkoutPrice.BackColor = SystemColors.Control;
            lblPreWorkoutPrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPreWorkoutPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblPreWorkoutPrice.Location = new Point(364, 101);
            lblPreWorkoutPrice.Name = "lblPreWorkoutPrice";
            lblPreWorkoutPrice.Size = new Size(85, 24);
            lblPreWorkoutPrice.TabIndex = 91;
            lblPreWorkoutPrice.Text = "Rs 2300";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(253, 102);
            label7.Name = "label7";
            label7.Size = new Size(105, 19);
            label7.TabIndex = 30;
            label7.Text = "Pre-Workout";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(512, 102);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 29;
            label6.Text = "Fat Burn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(6, 251);
            label5.Name = "label5";
            label5.Size = new Size(106, 19);
            label5.TabIndex = 28;
            label5.Text = "Multi Vitamin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(253, 251);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 27;
            label4.Text = "Creatine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(511, 251);
            label3.Name = "label3";
            label3.Size = new Size(103, 19);
            label3.TabIndex = 26;
            label3.Text = "Mass Gainer";
            // 
            // lblProteinPrice
            // 
            lblProteinPrice.AutoSize = true;
            lblProteinPrice.BackColor = SystemColors.Control;
            lblProteinPrice.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblProteinPrice.ForeColor = SystemColors.ActiveCaptionText;
            lblProteinPrice.Location = new Point(121, 101);
            lblProteinPrice.Name = "lblProteinPrice";
            lblProteinPrice.Size = new Size(85, 24);
            lblProteinPrice.TabIndex = 25;
            lblProteinPrice.Text = "Rs 2500";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = SystemColors.Control;
            lblLogin.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(6, 102);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(78, 24);
            lblLogin.TabIndex = 25;
            lblLogin.Text = "Protein";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(253, 149);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(193, 99);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(6, 149);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(193, 99);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(511, 149);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(182, 99);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(512, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(253, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 95);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Protien;
            pictureBox1.Location = new Point(6, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(64, 64, 64);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(289, 209);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 21;
            label2.Text = "Product";
            // 
            // DGVMeasurement
            // 
            DGVMeasurement.AllowUserToDeleteRows = false;
            DGVMeasurement.BackgroundColor = SystemColors.ButtonHighlight;
            DGVMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMeasurement.Location = new Point(288, 541);
            DGVMeasurement.Name = "DGVMeasurement";
            DGVMeasurement.RowHeadersWidth = 62;
            DGVMeasurement.RowTemplate.Height = 33;
            DGVMeasurement.Size = new Size(1425, 168);
            DGVMeasurement.TabIndex = 60;
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMembers.Location = new Point(1001, 50);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(123, 24);
            lblMembers.TabIndex = 48;
            lblMembers.Text = "Membership";
            // 
            // cmbMember
            // 
            cmbMember.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMember.FormattingEnabled = true;
            cmbMember.Location = new Point(1170, 47);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(356, 34);
            cmbMember.TabIndex = 49;
            // 
            // lblPaidAmount
            // 
            lblPaidAmount.AutoSize = true;
            lblPaidAmount.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaidAmount.Location = new Point(1006, 205);
            lblPaidAmount.Name = "lblPaidAmount";
            lblPaidAmount.Size = new Size(126, 24);
            lblPaidAmount.TabIndex = 52;
            lblPaidAmount.Text = "Amount Paid";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1006, 263);
            label1.Name = "label1";
            label1.Size = new Size(185, 24);
            label1.TabIndex = 52;
            label1.Text = "Remaining Amount";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1237, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 31);
            textBox2.TabIndex = 53;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1237, 256);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(289, 31);
            textBox3.TabIndex = 54;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBox13);
            panel2.Location = new Point(288, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(59, 121);
            panel2.TabIndex = 86;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(7, 28);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(43, 46);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 87;
            pictureBox13.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Location = new Point(291, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(412, 89);
            flowLayoutPanel1.TabIndex = 85;
            // 
            // cmbPackage
            // 
            cmbPackage.Font = new Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(1170, 94);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(356, 34);
            cmbPackage.TabIndex = 88;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1001, 97);
            label8.Name = "label8";
            label8.Size = new Size(83, 24);
            label8.TabIndex = 87;
            label8.Text = "Package";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1006, 381);
            label9.Name = "label9";
            label9.Size = new Size(134, 24);
            label9.TabIndex = 89;
            label9.Text = "Payment Date";
            // 
            // DtpPaymentDate
            // 
            DtpPaymentDate.Location = new Point(1237, 374);
            DtpPaymentDate.Name = "DtpPaymentDate";
            DtpPaymentDate.Size = new Size(289, 31);
            DtpPaymentDate.TabIndex = 90;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Paid ", "Partial", "Decline" });
            cmbPaymentStatus.Location = new Point(1237, 416);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(289, 33);
            cmbPaymentStatus.TabIndex = 92;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Merriweather", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1006, 425);
            label10.Name = "label10";
            label10.Size = new Size(149, 24);
            label10.TabIndex = 91;
            label10.Text = "Payment Status";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1713, 710);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label10);
            Controls.Add(DtpPaymentDate);
            Controls.Add(label9);
            Controls.Add(cmbPackage);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(lblPayment);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(DGVMeasurement);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPayMethod);
            Controls.Add(label1);
            Controls.Add(lblPaidAmount);
            Controls.Add(lblAmount);
            Controls.Add(cmbMember);
            Controls.Add(lblMembers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVMeasurement).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPayment;
        private Label lblAmount;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblPayMethod;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label2;
        private DataGridView DGVMeasurement;
        private Label lblMembers;
        private ComboBox cmbMember;
        private Label lblPaidAmount;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox13;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblLogin;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblProteinPrice;
        private Label lblFatBurnPrice;
        private Label lblMassGainerPrice;
        private Label lblCreatinePrice;
        private Label lblVitaminPrice;
        private Label lblPreWorkoutPrice;
        private ComboBox cmbPackage;
        private Label label8;
        private Label label9;
        private DateTimePicker DtpPaymentDate;
        private ComboBox cmbPaymentStatus;
        private Label label10;
    }
}