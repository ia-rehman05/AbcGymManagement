using AbcGymManagement.Forms;
using AbcGymManagement.Forms.AdminForms;

namespace AbcGymManagement
{
    public partial class Dashboard : Form
    {
        int PW;
        bool Hided;

        public Dashboard()
        {
            InitializeComponent();
            PW = MainPanel.Width;
            Hided = false;
        }
        public void loadform(object Form)
        {
            if (this.Daughterpanel.Controls.Count > 0)
                this.Daughterpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Daughterpanel.Controls.Add(f);
            this.Daughterpanel.Tag = f;
            f.Show();
        }
        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            loadform(new Member());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblGymName_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadform(new Trainer());
        }

        private void BtnMeasurements_Click(object sender, EventArgs e)
        {
            loadform(new Measurement());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FeedBack());
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            loadform(new Measurement());

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            loadform(new Trainer());

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DaughterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            loadform(new Payment());

        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            loadform(new Membership());
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            loadform(new Workout());
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            loadform(new Diet());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            loadform(new Attendance());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //loadform(new )
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());
        }

        private void btnHalls_Click(object sender, EventArgs e)
        {
            loadform(new Hall());

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettting_Click(object sender, EventArgs e)
        {

        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            loadform(new FeedBack());

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            loadform(new Inventory());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hided)
            {
                MainPanel.Width = MainPanel.Width + 20;
                if (MainPanel.Width >= PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                MainPanel.Width = MainPanel.Width - 20;
                if (MainPanel.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new Member());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            loadform(new Membership());

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            loadform(new Workout());

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            loadform(new Diet());

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            loadform(new Attendance());

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            loadform(new Hall());

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            loadform(new Payment());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
        }

        private void Daughterpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            loadform(new RoomType());

        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            loadform(new Package());
        }
    }
}
