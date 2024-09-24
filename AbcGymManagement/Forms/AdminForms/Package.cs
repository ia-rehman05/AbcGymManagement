using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Packages;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json.Linq;
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
    public partial class Package : Form
    {
        private readonly HttpPackageHandler _httpPackage;
        private string _apiUrl = "https://localhost:7160/api/Package";
        private Guid? _selectedPackageId = null;
        public Package()
        {
            InitializeComponent();
            _httpPackage = new HttpPackageHandler("https://localhost:7160/");
            LoadPackages();
        }

        private void Package_Load(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var package = new PackageDto
            {
                //Id = _selectedPackageId ?? Guid.NewGuid(),
                Name = txtName.Text,
                Amount = Convert.ToInt32(txtAmout.Text),
                Duration = txtDuration.Text,
                StartDate = DTPStart.Value,
                EndDate = DTPEnd.Value,
                IsActive = ChkIsActive.Checked
            };

            bool isSuccess = await _httpPackage.AddPackageAsync(_apiUrl, package);
            if (isSuccess)
            {
                MessageBox.Show("Package added successfully.");
                LoadPackages();
            }
            else
            {
                MessageBox.Show("Failed to add Package.");

            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (_selectedPackageId.HasValue)
            {
                var updatedPackage = new PackageResponseDto
                {
                    Name = txtName.Text,
                    Amount = decimal.Parse(txtAmout.Text),
                    Duration = txtDuration.Text,
                    StartDate = DTPStart.Value,
                    EndDate = DTPEnd.Value,
                    IsActive = ChkIsActive.Checked
                };

                string fullUrl = $"{_apiUrl}/{_selectedPackageId.Value}";
                bool isSuccess = await _httpPackage.UpdatePackageAsync(fullUrl, updatedPackage);

                if (isSuccess)
                {
                    MessageBox.Show("Packages updated successfully!");
                    LoadPackages();

                }
                else
                {
                    MessageBox.Show("Failed to update Packages.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Packages to update.");
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (_selectedPackageId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedPackageId.Value}";
                bool isSuccess = await _httpPackage.DeletePackageByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Package deleted successfully!");
                    LoadPackages();

                }
                else
                {
                    MessageBox.Show("Failed to delete Package.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Package to delete.");
            }
        }






        private async void LoadPackages()
        {
            try
            {
                var package = await _httpPackage.GetAllpackagesAsync(_apiUrl);

                if (package != null)
                {
                    DGVPackage.DataSource = package;
                }
                else
                {
                    MessageBox.Show("Failed to Load Packages.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void DGVPackage_DoubleClick(object sender, EventArgs e)
        {
            if (DGVPackage.SelectedRows.Count > 0)
            {
                var selectedRow = DGVPackage.SelectedRows[0];
                _selectedPackageId = (Guid)selectedRow.Cells["Id"].Value;
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtAmout.Text = selectedRow.Cells["Amount"].Value.ToString();
                txtDuration.Text = selectedRow.Cells["Duration"].Value.ToString();
                DTPStart.Value = Convert.ToDateTime(selectedRow.Cells["StartDate"].Value);
                DTPEnd.Value = Convert.ToDateTime(selectedRow.Cells["EndDate"].Value);
                ChkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);

            }
        }

        private void DGVPackage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

