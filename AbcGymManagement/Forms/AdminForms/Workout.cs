using AbcGymManagement.ApiRequestHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcGymManagement.Forms
{
    public partial class Workout : Form
    {
        private readonly HttpMembertHandler _member;
        private string _apiUrl = "https://localhost:7160/api/Inventory";

        public Workout()
        {
            InitializeComponent();
            _member = new HttpMembertHandler("https://localhost:7160/api/");
            LoadMembers();
        }

        private async void LoadMembers()
        {
            var members = await _member.GetAllMembersAsync("Member");
            cmbmember.DataSource = members;
            cmbmember.DisplayMember = "FirstName";
            cmbmember.ValueMember = "Id";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void Workout_Load(object sender, EventArgs e)
        {

        }
    }
}
