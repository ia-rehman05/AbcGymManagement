using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.Dtos.Measurements;
using GMS.Service.Dtos.Measurements;
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
    public partial class Measurement : Form
    {
        private readonly ApiCrudHandler<MeasurementDto, UpdateMeasurementDto> _apiCrudHandler;
        private readonly HttpHallRequestHandler _hallrequesthandler;
        private readonly HttpMembertHandler _memberHandler;

        private string _apiUrl = "https://localhost:7160/api/Measurement"; // Inventory API endpoint
        private string _HallUrl = "https://localhost:7160/api/Hak";

        private Guid? _selectedMeasurementId = null;

        public Measurement()
        {
            InitializeComponent();
            _apiCrudHandler = new ApiCrudHandler<MeasurementDto, UpdateMeasurementDto>("https://localhost:7160/");
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");
            LoadMembers();
        }
        private async void LoadMembers()
        {
            var members = await _memberHandler.GetAllMembersAsync("Member");
            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "FirstName";
            cmbMembers.ValueMember = "Id";
        }

        private void Measurement_Load(object sender, EventArgs e)
        {

        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
