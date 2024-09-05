using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.Forms.AdminForms;
using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using RestSharp;
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
    public partial class Hall : Form
    {
        private readonly HttpHallRequestHandler _httpHall;
        private string _apiUrl = "https://localhost:7160/api/Hall";
        private Guid? _selectedHallId = null;



        public Hall()
        {
            InitializeComponent();
            _httpHall = new HttpHallRequestHandler("https://localhost:7160/"); // Base URL for the API
            Loadhall();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
          
            var halldto = new HallDto
            {
                Id = _selectedHallId ?? Guid.NewGuid(),
                Name = txtName.Text,
                Capacity = txtCapacity.Text,
                Location = txtLocation.Text,
                AvailabilityStatus = ChkAvailible.Checked,
                RoomTypeId = (Guid)cmbRoomType.SelectedValue
            };

            bool isSuccess = await _httpHall.PostHallAsync(_apiUrl, halldto);

            if (isSuccess)
            {
                MessageBox.Show("Hall added successfully.");
                Loadhall();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add hall.");
                Loadhall();
                ClearForm();
            }
        }

        private async void Hall_Load(object sender, EventArgs e)
        {
            await LoadHallsAsync();
        }

        private async void Loadhall()
        {
            try
            {
                var hall = await _httpHall.GetAllHallsAsync(_apiUrl);

                if (hall != null)
                {
                    DGVHall.DataSource = hall;
                }
                else
                {
                    MessageBox.Show("Failed to load RoomTypes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
        private async Task LoadHallsAsync()
        {
            try
            {
                var roomTypes = await _httpHall.GetRoomTypesAsync("api/RoomType");
                cmbRoomType.DataSource = roomTypes;
                cmbRoomType.DisplayMember = "Name";
                cmbRoomType.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room types: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtCapacity.Clear();
            txtLocation.Clear();
            ChkAvailible.Checked = false;
            cmbRoomType.SelectedIndex = -1;
            _selectedHallId = null;
        }
        private void DGVMeasurement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (_selectedHallId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedHallId.Value}";
                bool isSuccess = await _httpHall.DeleteHallByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType deleted successfully!");
                    Loadhall();
                    ClearForm();

                }
                else
                {
                    MessageBox.Show("Failed to delete Hall.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Hall to delete.");
            }
        }
    

        private async void btnEdit_Click(object sender, EventArgs e)
        {


            if (_selectedHallId.HasValue)
            {
                var UpdatedHall = new HallDto
                {
                    Id = _selectedHallId.Value,
                    Name = txtName.Text,
                    RoomTypeId = (Guid)cmbRoomType.SelectedValue,
                    Capacity = txtCapacity.Text,
                    Location = txtLocation.Text,
                    AvailabilityStatus = ChkAvailible.Checked
                };

                string fullUrl = $"{_apiUrl}/{_selectedHallId.Value}";
                bool isSuccess = await _httpHall.UpdateHallAsync(fullUrl, UpdatedHall);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType updated successfully!");
                    Loadhall(); // Refresh the grid after updating
                    ClearForm();

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

            //if (_selectedHallId.HasValue)
            //{
            //    var updatedHall = new HallDto
            //    {
            //        Id = _selectedHallId.Value,
            //        Name = txtName.Text,
            //        RoomTypeId = (Guid)cmbRoomType.SelectedValue,
            //        Capacity = txtCapacity.Text,
            //        Location = txtLocation.Text,
            //        AvailabilityStatus = ChkAvailible.Checked

            //    };

            //    string fullUrl = $"{_apiUrl}/{_selectedHallId.Value}";
            //    //bool isSuccess = await _httpHall.UpdateHallAsync(fullUrl, updatedHall);
            //    if (isSuccess)
            //    {
            //        MessageBox.Show("RoomType updated successfully!");
            //        //LoadRoomTypes(); // Refresh the grid after updating
            //        //Clear();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to update RoomType.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a RoomType to update.");
            //}
        }

        private void DGVHall_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DGVHall_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVHall.SelectedRows.Count > 0)
            {
                var selectedRow = DGVHall.SelectedRows[0];
                _selectedHallId = (Guid)selectedRow.Cells["Id"].Value;
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                cmbRoomType.SelectedValue = selectedRow.Cells["RoomTypeId"].Value;
                txtCapacity.Text = selectedRow.Cells["Capacity"].Value.ToString();
                txtLocation.Text = selectedRow.Cells["Location"].Value.ToString();
                ChkAvailible.Checked = Convert.ToBoolean(selectedRow.Cells["AvailabilityStatus"].Value);
            }
        }
    }
}



