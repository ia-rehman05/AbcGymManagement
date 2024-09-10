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
    public partial class Attendance : Form
    {
        private readonly HttpAttendance httpAttendance;
        private readonly HttpMembertHandler _memberHandler;

        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }
        private async void LoadMembers()
        {
            var trainers = await _trainerHandler.GetAllTrainersAsync("Trainer");
            cmbTrainer.DataSource = trainers;
            cmbTrainer.DisplayMember = "FirstName";  // Assuming TrainerResponseDto has a Name property
            cmbTrainer.ValueMember = "Id";
        }

    }
}
