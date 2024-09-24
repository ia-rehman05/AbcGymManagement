using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Inventory;
using GMS.Service.Dtos.InventoryItems;
using GMS.Service.Dtos.Packages;
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
    public partial class Inventory : Form
    {

        private readonly ApiCrudHandler<InventoryItemDto, InventoryResponseDto> _httpCrudRequest;
        private readonly HttpHallRequestHandler _httpHallRequest;
        private string _apiUrl = "https://localhost:7160/api/Inventory";
        private string apiUrl = "https://localhost:7160/api/Hall";

        private Guid? _selectedInventoryId = null;

        public Inventory()
        {
            InitializeComponent();
            _httpCrudRequest = new ApiCrudHandler<InventoryItemDto, InventoryResponseDto>("https://localhost:7160/api/");
            _httpHallRequest = new HttpHallRequestHandler("https://localhost:7160/api/");

            LoadHalls();
            LoadInventory();
        }
        private async void LoadInventory()
        {
            try
            {
                var inventory = await _httpCrudRequest.GetAllAsync(_apiUrl);

                if (inventory != null && inventory.Any())
                {
                    DGVInventory.DataSource = inventory;
                }
                else
                {
                    MessageBox.Show("No inventory found or failed to load inventory.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private async void LoadHalls()
        {
            var halls = await _httpHallRequest.GetAllHallsAsync(apiUrl);
            cmbHall.DataSource = halls;
            cmbHall.DisplayMember = "Name";
            cmbHall.ValueMember = "Id";
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var inventoryItem = new InventoryItemDto
            {
                Id = _selectedInventoryId ?? Guid.NewGuid(),

                HallId = (Guid)cmbHall.SelectedValue,
                ItemName = txtItemName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                MaintainanceSchedule = txtSchedule.Text,
                LastMaintenanceDate = dtpLastMainatainanace.Value,
                NextMaintenanceDate = dtpNextMaintainanceDate.Value
            };

            bool isSuccess = await _httpCrudRequest.AddAsync(_apiUrl, inventoryItem);
            if (isSuccess)
            {
                MessageBox.Show("Inventory item added successfully.");
                LoadInventory();
            }
            else
            {
                MessageBox.Show("Failed to add inventory item.");
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedInventoryId != null)
            {
                var UpdateinventoryItem = new InventoryResponseDto
                {
                    Id = _selectedInventoryId.Value,
                    HallId = (Guid)cmbHall.SelectedValue,
                    ItemName = txtItemName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    MaintainanceSchedule = txtSchedule.Text,
                    LastMaintenanceDate = dtpLastMainatainanace.Value,
                    NextMaintenanceDate = dtpNextMaintainanceDate.Value
                };
                string fullUrl = $"{_apiUrl}/{_selectedInventoryId.Value}";
                bool isSuccess = await _httpCrudRequest.UpdateAsync(fullUrl, UpdateinventoryItem);
                if (isSuccess)
                {
                    MessageBox.Show("Inventory item Edit successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add inventory item.");
                }
            }
            else
            {
                MessageBox.Show("Please Select any Id for Update");
            }
        }


        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void DGVInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVInventory.SelectedRows.Count > 0)
            {
                var selectedRow = DGVInventory.SelectedRows[0];

                _selectedInventoryId = (Guid)selectedRow.Cells["Id"].Value;

                txtItemName.Text = selectedRow.Cells["ItemName"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                txtSchedule.Text = selectedRow.Cells["MaintainanceSchedule"].Value.ToString();
                dtpLastMainatainanace.Value = Convert.ToDateTime(selectedRow.Cells["LastMaintenanceDate"].Value);
                dtpNextMaintainanceDate.Value = Convert.ToDateTime(selectedRow.Cells["NextMaintenanceDate"].Value);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedInventoryId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedInventoryId.Value}";
                bool isSuccess = await _httpCrudRequest.DeleteByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Inventory item deleted successfully!");
                    LoadInventory();
                        }
                else
                {
                    MessageBox.Show("Failed to delete inventory item.");
                }
            }
            else
            {
                MessageBox.Show("Please select an inventory item to delete.");
            }
        }
    }
}
