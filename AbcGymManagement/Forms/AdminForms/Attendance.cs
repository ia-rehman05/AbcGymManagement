using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Attendances;
using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AbcGymManagement.Forms
{
    public partial class Attendance : Form
    {
        private readonly HttpAttendaneHandler _httpAttendance;
        private readonly HttpMembertHandler _memberHandler;
        private string _apiUrl = "https://localhost:7160/api/Attendance";
        private Guid? _selectedAttendanceId = null;


        public Attendance()
        {
            InitializeComponent();
            _httpAttendance = new HttpAttendaneHandler("https://localhost:7160/"); // Base URL for the API
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");

            LoadMembers();
            LoadAttendance();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }
        private async void LoadMembers()
        {
            var members = await _memberHandler.GetAllMembersAsync("Member");
            cmbMember.DataSource = members;
            cmbMember.DisplayMember = "FirstName";
            cmbMember.ValueMember = "Id";
        }

        private async void btnAddAttendace_Click(object sender, EventArgs e)
        {
            var attendance = new AttendanceDto
            {
                Date = DtpDate.Value,
                CheckInTime = DtpCheckin.Value,
                CheckOutTime = dtpCheckout.Value,

                MemberId = cmbMember.SelectedValue.ToString(),
            };
            bool isSuccess = await _httpAttendance.AddAttendanceAsync(_apiUrl, attendance);
            if (isSuccess)
            {
                MessageBox.Show("Attendance added successfully!");
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Failed to add Attendance.");
                LoadMembers();
            }
        }



        private async void LoadAttendance()
        {
            try
            {
                var attendance = await _httpAttendance.GetAttendancesAsync(_apiUrl);

                if (attendance != null)
                {
                    DGVAttendance.DataSource = attendance;
                }
                else
                {
                    MessageBox.Show("Failed to attendance.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void DGVAttendance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVAttendance.SelectedRows.Count > 0)
            {
                var selectedRow = DGVAttendance.SelectedRows[0];

                _selectedAttendanceId = (Guid)selectedRow.Cells["Id"].Value;

                DtpDate.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                DtpCheckin.Value = Convert.ToDateTime(selectedRow.Cells["CheckInTime"].Value);
                dtpCheckout.Value = Convert.ToDateTime(selectedRow.Cells["CheckOutTime"].Value);
            }
        }

        private void DGVAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedAttendanceId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedAttendanceId.Value}";

                bool isSuccess = await _httpAttendance.DeleteAttendanceAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Attendance deleted successfully!");
                    LoadAttendance();
                }


                else
                {
                    MessageBox.Show("Failed to delete Attendance.");
                    LoadAttendance();

                }
            }
            else
            {
                MessageBox.Show("Please select a Attendance to delete.");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedAttendanceId.HasValue)
            {
                var UpdateAttendace = new AttendanceDto
                {
                    Id = _selectedAttendanceId.Value,
                    Date = DtpDate.Value,
                    CheckInTime = DtpCheckin.Value,
                    CheckOutTime = dtpCheckout.Value,
                   
                };

                string fullUrl = $"{_apiUrl}/{_selectedAttendanceId.Value}";
                bool isSuccess = await _httpAttendance.UpdateAttendanceAsync(fullUrl, UpdateAttendace);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType updated successfully!");
                    LoadAttendance();

                }
                else
                {
                    MessageBox.Show("Failed to update Hall.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Hall to update.");
            }
        }
    }
}
