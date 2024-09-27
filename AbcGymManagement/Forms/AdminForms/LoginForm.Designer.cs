namespace AbcGymManagement.Forms.AdminForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox12 = new PictureBox();
            panel2 = new Panel();
            LblRegister = new Label();
            btnlogin = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            txtEmail = new TextBox();
            lblName = new Label();
            lblPAss = new Label();
            label2 = new Label();
            lblLogin = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wq;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(854, 571);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LblRegister);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblPAss);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(845, -1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 570);
            panel1.TabIndex = 1;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(470, 2);
            pictureBox12.Margin = new Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(54, 50);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 12;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(2, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 566);
            panel2.TabIndex = 11;
            // 
            // LblRegister
            // 
            LblRegister.AutoSize = true;
            LblRegister.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LblRegister.ForeColor = Color.Peru;
            LblRegister.Location = new Point(302, 410);
            LblRegister.Margin = new Padding(2, 0, 2, 0);
            LblRegister.Name = "LblRegister";
            LblRegister.Size = new Size(70, 19);
            LblRegister.TabIndex = 10;
            LblRegister.Text = "REGISTER";
            LblRegister.Click += LblRegister_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.Control;
            btnlogin.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = SystemColors.ActiveCaptionText;
            btnlogin.Location = new Point(96, 380);
            btnlogin.Margin = new Padding(2);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(338, 27);
            btnlogin.TabIndex = 9;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(344, 333);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 8;
            label3.Text = "Forget Password";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.eye__1_;
            pictureBox3.Location = new Point(405, 306);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 249);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(338, 27);
            txtEmail.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ButtonHighlight;
            lblName.Location = new Point(96, 227);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 21);
            lblName.TabIndex = 5;
            lblName.Text = "User Name";
            // 
            // lblPAss
            // 
            lblPAss.AutoSize = true;
            lblPAss.Font = new Font("Bahnschrift Condensed", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPAss.ForeColor = SystemColors.ButtonHighlight;
            lblPAss.Location = new Point(96, 284);
            lblPAss.Margin = new Padding(2, 0, 2, 0);
            lblPAss.Name = "lblPAss";
            lblPAss.Size = new Size(64, 21);
            lblPAss.TabIndex = 4;
            lblPAss.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(159, 410);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 19);
            label2.TabIndex = 3;
            label2.Text = "Don't Have Account?";
            label2.Click += label2_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(222, 183);
            lblLogin.Margin = new Padding(2, 0, 2, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(89, 29);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(161, 38);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(96, 306);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 27);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 568);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lblLogin;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblName;
        private Label lblPAss;
        private Label label2;
        private Button btnlogin;
        private Label label3;
        private PictureBox pictureBox3;
        private Label LblRegister;
        private Panel panel2;
        private PictureBox pictureBox12;
    }
}