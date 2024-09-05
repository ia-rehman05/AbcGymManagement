using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbcGymManagement.Forms.AdminForms
{
    public partial class RoomType : Form
    {
        private readonly HttpRoomRequestHandler _roomType;
        private string _apiUrl = "https://localhost:7160/api/RoomType";
        private Guid? _selectedRoomTypeId = null;
        public RoomType()
        {
            InitializeComponent();
            _roomType = new HttpRoomRequestHandler();
            LoadRoomTypes();
        }


        private void RoomType_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var roomTypeDto = new RoomTypeDto
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text,
                Description = txtDescription.Text,
            };
            bool isSuccess = await _roomType.AddRoomTypeAsync(_apiUrl, roomTypeDto);


            if (isSuccess)
            {
                MessageBox.Show("RoomType added successfully!");
                LoadRoomTypes(); 
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add RoomType.");
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (_selectedRoomTypeId.HasValue)
            {
                var updatedRoomType = new RoomTypeDto
                {
                    Id = _selectedRoomTypeId.Value,
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };

                string fullUrl = $"{_apiUrl}/{_selectedRoomTypeId.Value}";
                bool isSuccess = await _roomType.UpdateRoomTypeAsync(fullUrl, updatedRoomType);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType updated successfully!");
                    LoadRoomTypes(); 
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to update RoomType.");
                }
            }
            else
            {
                MessageBox.Show("Please select a RoomType to update.");
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRoomTypeId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedRoomTypeId.Value}";
                bool isSuccess = await _roomType.DeleteRoomTypeByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType deleted successfully!");
                    LoadRoomTypes();
                    Clear();

                }
                else
                {
                    MessageBox.Show("Failed to delete RoomType.");
                }
            }
            else
            {
                MessageBox.Show("Please select a RoomType to delete.");
            }
        }




        private void DGVRoomType_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVRoomType.SelectedRows.Count > 0)
            {
                var selectedRow = DGVRoomType.SelectedRows[0];
                // Assuming ID is in the first column
                _selectedRoomTypeId = (Guid)selectedRow.Cells["Id"].Value; // Replace "Id" with the actual column name
                txtName.Text = selectedRow.Cells["Name"].Value.ToString(); // Replace "Name" with the actual column name
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString(); // Replace "Description" with the actual column name
            }

        }


        private async void LoadRoomTypes()
        {
            try
            {
                var roomTypes = await _roomType.GetAllRoomTypesAsync(_apiUrl);

                if (roomTypes != null)
                {
                    DGVRoomType.DataSource = roomTypes.Select(r => new
                    {
                        r.Id,
                        r.Name,
                        r.Description
                    }).ToList();
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



        public void Clear()
        {
            txtName.Clear();
            txtDescription.Clear();
            //_selectedRoomTypeId = null;
        }


        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
        }

        private void DGVRoomType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

