using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.Forms.AdminForms;
using GMS.Service.Dtos.Room;
using GMS.Service.Dtos.Trainers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AbcGymManagement.Forms
{
    public partial class Trainer : Form
    {
        private readonly HttpTrainerHandler _trainer;
        private string _apiUrl = "https://localhost:7160/api/Trainer";
        private Guid? _selectedTrainerId = null;
        public Trainer()
        {
            InitializeComponent();
            _trainer = new HttpTrainerHandler("https://localhost:7160");
            LoadTrainers();

        }
        private async void btnAddRecord_Click(object sender, EventArgs e)
        {
            var trainerCreateDto = new TrainerCreateDto
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = string.IsNullOrWhiteSpace(txtAge.Text) ? 0 : Convert.ToInt32(txtAge.Text),
                Gender = cmbGender.SelectedItem?.ToString(),
                Address = txtAddress.Text,
                DateOfBirth = DTPDOB.Value,
                IsActive = ChkIsActive.Checked,
                Specialization = cmbSpecialization.SelectedItem?.ToString(),
                Schedule = cmbSchedule.SelectedItem?.ToString(),
                TotalExperience = string.IsNullOrWhiteSpace(txtExperince.Text) ? 0 : Convert.ToInt32(txtExperince.Text),
                Shift = txtShift.Text
            };

            string Url = "https://localhost:7160/api/Auth/register/trainer";
            bool isSuccess = await _trainer.AddTrainerAsync(Url, trainerCreateDto);

            if (isSuccess)
            {
                MessageBox.Show("Trainer added successfully!");
                LoadTrainers();
            }
            else
            {
                MessageBox.Show("Failed to add Trainer.");
            }
        }

        private void Trainer_Load(object sender, EventArgs e)
        {

        }

        private void Trainer_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (!_selectedTrainerId.HasValue)
            {
                MessageBox.Show("Please select a trainer to update.");
                return;
            }

            var updatedTrainer = new TrainerCreateDto
            {
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = int.Parse(txtAge.Text),
                Gender = cmbGender.SelectedItem?.ToString(),
                Address = txtAddress.Text,
                DateOfBirth = DTPDOB.Value,
                IsActive = ChkIsActive.Checked,
                Password = txtPassword.Text,
                Specialization = cmbSpecialization.SelectedItem?.ToString(),
                Schedule = cmbSchedule.SelectedItem?.ToString(),
                TotalExperience = int.Parse(txtExperince.Text),
                Shift = txtShift.Text
            };

            string apiUrl = $"{_apiUrl}/{_selectedTrainerId}"; // Construct the correct API URL
            var result = await _trainer.UpdateTrainerAsync(apiUrl, updatedTrainer);

            if (result)
            {
                MessageBox.Show("Trainer updated successfully.");
                LoadTrainers(); // Reload the DataGridView with updated data
            }
            else
            {
                MessageBox.Show("Failed to update trainer.");
            }
        }
        

            private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTrainerId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedTrainerId.Value}";

                bool isSuccess = await _trainer.DeleteTrainerAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Trainer deleted successfully!");
                    LoadTrainers();
                }
                else
                {
                    MessageBox.Show("Failed to delete Trainer.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Trainer to delete.");
            }
        }




        #region page Load Methods







        private async void LoadTrainers()
        {
            try
            {
                var trainers = await _trainer.GetAllTrainersAsync("api/Trainer");

                if (trainers != null)
                {
                    if (!DGVTrainer.Columns.Contains("Id"))
                    {
                        DGVTrainer.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            Name = "Id",
                            HeaderText = "Trainer ID",
                            DataPropertyName = "Id",
                            Visible = false
                        });
                    }

                    DGVTrainer.DataSource = trainers;
                }
                else
                {
                    MessageBox.Show("Failed to load Trainers.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }

        }

        private void DGVTrainer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        private void DGVTrainer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVTrainer.SelectedRows.Count > 0)
            {
                var selectedRow = DGVTrainer.SelectedRows[0];

                _selectedTrainerId = (Guid)selectedRow.Cells["Id"].Value;

                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                cmbGender.SelectedItem = selectedRow.Cells["Gender"].Value?.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                DTPDOB.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                ChkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
                cmbSpecialization.SelectedItem = selectedRow.Cells["Specialization"].Value?.ToString();
                cmbSchedule.SelectedItem = selectedRow.Cells["Schedule"].Value?.ToString();
                txtExperince.Text = selectedRow.Cells["TotalExperience"].Value.ToString();
                txtShift.Text = selectedRow.Cells["Shift"].Value.ToString();
            }
        }
    }
}
