using AbcGymManagement.Forms;

namespace AbcGymManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.DaughterPanel.Controls.Count > 0)
                this.DaughterPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.DaughterPanel.Controls.Add(f);
            this.DaughterPanel.Tag = f;
            f.Show();
        }
        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            loadform(new AddMember());
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

        }

        private void BtnMeasurements_Click(object sender, EventArgs e)
        {
            loadform(new Measurement());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

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

        }
    }
}
