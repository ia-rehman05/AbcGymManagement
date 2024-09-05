namespace AbcGymManagement
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            MainPanel = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LblGymName = new Label();
            BtnAddMember = new Button();
            BtnMeasurements = new Button();
            btnTrainer = new Button();
            btnMembership = new Button();
            btnWorkout = new Button();
            btnDiet = new Button();
            btnAttendance = new Button();
            btnReport = new Button();
            btnFeedback = new Button();
            btnInventory = new Button();
            btnHalls = new Button();
            btnPayment = new Button();
            btnLogout = new Button();
            Daughterpanel = new Panel();
            panel2 = new Panel();
            pictureBox17 = new PictureBox();
            LblQuote = new Label();
            pictureBox16 = new PictureBox();
            btnSettting = new Button();
            pictureBox12 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SidebarPanel = new Panel();
            pictureBox18 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox2 = new PictureBox();
            MainPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(64, 64, 64);
            MainPanel.Controls.Add(panel3);
            MainPanel.Controls.Add(BtnAddMember);
            MainPanel.Controls.Add(BtnMeasurements);
            MainPanel.Controls.Add(btnTrainer);
            MainPanel.Controls.Add(btnMembership);
            MainPanel.Controls.Add(btnWorkout);
            MainPanel.Controls.Add(btnDiet);
            MainPanel.Controls.Add(btnAttendance);
            MainPanel.Controls.Add(btnReport);
            MainPanel.Controls.Add(btnFeedback);
            MainPanel.Controls.Add(btnInventory);
            MainPanel.Controls.Add(btnHalls);
            MainPanel.Controls.Add(btnPayment);
            MainPanel.Controls.Add(btnLogout);
            MainPanel.ForeColor = SystemColors.ControlDarkDark;
            MainPanel.Location = new Point(49, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(239, 710);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(LblGymName);
            panel3.Location = new Point(1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 63);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(110, 24);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 3;
            label1.Text = "GYM";
            label1.Click += label1_Click;
            // 
            // LblGymName
            // 
            LblGymName.AutoSize = true;
            LblGymName.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LblGymName.ForeColor = SystemColors.ButtonHighlight;
            LblGymName.Location = new Point(56, 21);
            LblGymName.Name = "LblGymName";
            LblGymName.Size = new Size(60, 28);
            LblGymName.TabIndex = 2;
            LblGymName.Text = "ABC";
            LblGymName.Click += LblGymName_Click;
            // 
            // BtnAddMember
            // 
            BtnAddMember.BackColor = Color.FromArgb(64, 64, 64);
            BtnAddMember.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAddMember.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAddMember.ForeColor = SystemColors.ButtonHighlight;
            BtnAddMember.Location = new Point(-15, 59);
            BtnAddMember.Name = "BtnAddMember";
            BtnAddMember.Size = new Size(262, 48);
            BtnAddMember.TabIndex = 1;
            BtnAddMember.Text = "             Add Member";
            BtnAddMember.TextAlign = ContentAlignment.MiddleLeft;
            BtnAddMember.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAddMember.UseVisualStyleBackColor = false;
            BtnAddMember.Click += BtnAddMember_Click;
            // 
            // BtnMeasurements
            // 
            BtnMeasurements.BackColor = Color.FromArgb(64, 64, 64);
            BtnMeasurements.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMeasurements.ForeColor = SystemColors.ButtonHighlight;
            BtnMeasurements.Location = new Point(-12, 103);
            BtnMeasurements.Name = "BtnMeasurements";
            BtnMeasurements.Size = new Size(262, 48);
            BtnMeasurements.TabIndex = 2;
            BtnMeasurements.Text = "            Measurements";
            BtnMeasurements.TextAlign = ContentAlignment.MiddleLeft;
            BtnMeasurements.UseVisualStyleBackColor = false;
            BtnMeasurements.Click += BtnMeasurements_Click;
            // 
            // btnTrainer
            // 
            btnTrainer.BackColor = Color.FromArgb(64, 64, 64);
            btnTrainer.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTrainer.ForeColor = SystemColors.ButtonHighlight;
            btnTrainer.Location = new Point(-12, 147);
            btnTrainer.Name = "btnTrainer";
            btnTrainer.Size = new Size(262, 48);
            btnTrainer.TabIndex = 3;
            btnTrainer.Text = "            Trainer";
            btnTrainer.TextAlign = ContentAlignment.MiddleLeft;
            btnTrainer.UseVisualStyleBackColor = false;
            btnTrainer.Click += button8_Click;
            // 
            // btnMembership
            // 
            btnMembership.BackColor = Color.FromArgb(64, 64, 64);
            btnMembership.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMembership.ForeColor = SystemColors.ButtonHighlight;
            btnMembership.Location = new Point(-12, 191);
            btnMembership.Name = "btnMembership";
            btnMembership.Size = new Size(262, 48);
            btnMembership.TabIndex = 4;
            btnMembership.Text = "            Membership";
            btnMembership.TextAlign = ContentAlignment.MiddleLeft;
            btnMembership.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMembership.UseVisualStyleBackColor = false;
            btnMembership.Click += btnMembership_Click;
            // 
            // btnWorkout
            // 
            btnWorkout.BackColor = Color.FromArgb(64, 64, 64);
            btnWorkout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnWorkout.ForeColor = SystemColors.ButtonHighlight;
            btnWorkout.Location = new Point(-12, 235);
            btnWorkout.Name = "btnWorkout";
            btnWorkout.Size = new Size(262, 48);
            btnWorkout.TabIndex = 5;
            btnWorkout.Text = "            Workout";
            btnWorkout.TextAlign = ContentAlignment.MiddleLeft;
            btnWorkout.UseVisualStyleBackColor = false;
            btnWorkout.Click += btnWorkout_Click;
            // 
            // btnDiet
            // 
            btnDiet.BackColor = Color.FromArgb(64, 64, 64);
            btnDiet.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiet.ForeColor = SystemColors.ButtonHighlight;
            btnDiet.Location = new Point(-12, 279);
            btnDiet.Name = "btnDiet";
            btnDiet.Size = new Size(262, 48);
            btnDiet.TabIndex = 6;
            btnDiet.Text = "            Diet";
            btnDiet.TextAlign = ContentAlignment.MiddleLeft;
            btnDiet.UseVisualStyleBackColor = false;
            btnDiet.Click += btnDiet_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(64, 64, 64);
            btnAttendance.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAttendance.ForeColor = SystemColors.ButtonHighlight;
            btnAttendance.Location = new Point(-12, 320);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(262, 48);
            btnAttendance.TabIndex = 7;
            btnAttendance.Text = "            Attandance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(64, 64, 64);
            btnReport.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.ForeColor = SystemColors.ButtonHighlight;
            btnReport.Location = new Point(-12, 364);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(262, 48);
            btnReport.TabIndex = 8;
            btnReport.Text = "            Report";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(64, 64, 64);
            btnFeedback.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFeedback.ForeColor = SystemColors.ButtonHighlight;
            btnFeedback.Location = new Point(-12, 408);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(262, 48);
            btnFeedback.TabIndex = 9;
            btnFeedback.Text = "            FeedBack";
            btnFeedback.TextAlign = ContentAlignment.MiddleLeft;
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += button3_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(64, 64, 64);
            btnInventory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInventory.ForeColor = SystemColors.ButtonHighlight;
            btnInventory.Location = new Point(-12, 452);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(262, 48);
            btnInventory.TabIndex = 10;
            btnInventory.Text = "            Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnHalls
            // 
            btnHalls.BackColor = Color.FromArgb(64, 64, 64);
            btnHalls.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHalls.ForeColor = SystemColors.ButtonHighlight;
            btnHalls.Location = new Point(-12, 496);
            btnHalls.Name = "btnHalls";
            btnHalls.Size = new Size(262, 48);
            btnHalls.TabIndex = 11;
            btnHalls.Text = "            Halls";
            btnHalls.TextAlign = ContentAlignment.MiddleLeft;
            btnHalls.UseVisualStyleBackColor = false;
            btnHalls.Click += btnHalls_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(64, 64, 64);
            btnPayment.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayment.ForeColor = SystemColors.ButtonHighlight;
            btnPayment.Location = new Point(-12, 540);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(262, 48);
            btnPayment.TabIndex = 12;
            btnPayment.Text = "            Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 64, 64);
            btnLogout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(-12, 584);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(262, 48);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "            Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Daughterpanel
            // 
            Daughterpanel.Dock = DockStyle.Fill;
            Daughterpanel.Location = new Point(0, 0);
            Daughterpanel.Name = "Daughterpanel";
            Daughterpanel.Size = new Size(1713, 710);
            Daughterpanel.TabIndex = 2;
            Daughterpanel.Paint += Daughterpanel_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pictureBox17);
            panel2.Controls.Add(LblQuote);
            panel2.Controls.Add(pictureBox16);
            panel2.Controls.Add(btnSettting);
            panel2.Controls.Add(pictureBox12);
            panel2.Location = new Point(288, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1427, 63);
            panel2.TabIndex = 1;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = (Image)resources.GetObject("pictureBox17.Image");
            pictureBox17.Location = new Point(288, 3);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(85, 57);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 4;
            pictureBox17.TabStop = false;
            // 
            // LblQuote
            // 
            LblQuote.AutoSize = true;
            LblQuote.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            LblQuote.ForeColor = SystemColors.ButtonHighlight;
            LblQuote.Location = new Point(370, 16);
            LblQuote.Name = "LblQuote";
            LblQuote.Size = new Size(533, 30);
            LblQuote.TabIndex = 2;
            LblQuote.Text = "A little progress each day adds up to big results....";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = (Image)resources.GetObject("pictureBox16.Image");
            pictureBox16.Location = new Point(1167, 15);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(35, 34);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 14;
            pictureBox16.TabStop = false;
            // 
            // btnSettting
            // 
            btnSettting.BackColor = Color.FromArgb(64, 64, 64);
            btnSettting.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettting.ForeColor = SystemColors.ButtonHighlight;
            btnSettting.Location = new Point(1141, 0);
            btnSettting.Name = "btnSettting";
            btnSettting.Size = new Size(216, 63);
            btnSettting.TabIndex = 14;
            btnSettting.Text = "               Setting";
            btnSettting.TextAlign = ContentAlignment.MiddleLeft;
            btnSettting.UseVisualStyleBackColor = false;
            btnSettting.Click += btnSettting_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(1357, 2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(68, 63);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 4;
            pictureBox12.TabStop = false;
            pictureBox12.Click += pictureBox12_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.Black;
            SidebarPanel.Controls.Add(pictureBox18);
            SidebarPanel.Controls.Add(pictureBox3);
            SidebarPanel.Controls.Add(pictureBox13);
            SidebarPanel.Controls.Add(pictureBox14);
            SidebarPanel.Controls.Add(pictureBox15);
            SidebarPanel.Controls.Add(pictureBox4);
            SidebarPanel.Controls.Add(pictureBox5);
            SidebarPanel.Controls.Add(pictureBox6);
            SidebarPanel.Controls.Add(pictureBox10);
            SidebarPanel.Controls.Add(pictureBox7);
            SidebarPanel.Controls.Add(pictureBox8);
            SidebarPanel.Controls.Add(pictureBox9);
            SidebarPanel.Controls.Add(pictureBox11);
            SidebarPanel.Controls.Add(pictureBox2);
            SidebarPanel.Location = new Point(1, 1);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(47, 710);
            SidebarPanel.TabIndex = 0;
            SidebarPanel.Paint += SidebarPanel_Paint;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = (Image)resources.GetObject("pictureBox18.Image");
            pictureBox18.Location = new Point(4, 17);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(35, 28);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 14;
            pictureBox18.TabStop = false;
            pictureBox18.Click += pictureBox18_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 582);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(2, 538);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(43, 46);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            pictureBox13.Click += pictureBox13_Click;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(2, 494);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(43, 48);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 6;
            pictureBox14.TabStop = false;
            pictureBox14.Click += pictureBox14_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.Location = new Point(2, 450);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(43, 48);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 7;
            pictureBox15.TabStop = false;
            pictureBox15.Click += pictureBox15_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 406);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(43, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 362);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(2, 318);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(43, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(2, 145);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 48);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 10;
            pictureBox10.TabStop = false;
            pictureBox10.Click += pictureBox10_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(2, 277);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(2, 233);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(43, 48);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(2, 189);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(2, 101);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(43, 48);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 11;
            pictureBox11.TabStop = false;
            pictureBox11.Click += pictureBox11_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(2, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1713, 710);
            Controls.Add(SidebarPanel);
            Controls.Add(panel2);
            Controls.Add(MainPanel);
            Controls.Add(Daughterpanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            Load += Form1_Load;
            MainPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            SidebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel panel2;
        private Panel panel3;
        private Label LblGymName;
        private Label label1;
        private Button BtnAddMember;
        private Button btnTrainer;
        private Button BtnMeasurements;
        private Button btnReport;
        private Button btnAttendance;
        private Button btnDiet;
        private Button btnWorkout;
        private Button btnMembership;
        private Button btnHalls;
        private Button btnInventory;
        private Button btnFeedback;
        private Button btnPayment;
        private PictureBox pictureBox1;
        private PictureBox pictureBox12;
        private Button btnLogout;
        private PictureBox pictureBox16;
        private Button btnSettting;
        private Label LblQuote;
        private PictureBox pictureBox17;
        private System.Windows.Forms.Timer timer1;
        private Panel SidebarPanel;
        private PictureBox pictureBox18;
        private PictureBox pictureBox3;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private PictureBox pictureBox2;
        private Panel Daughterpanel;
    }
}
