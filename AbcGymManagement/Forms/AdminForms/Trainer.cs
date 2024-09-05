using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.Forms.AdminForms;
using GMS.Service.Dtos.Room;
using GMS.Service.Dtos.Trainers;
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
    public partial class Trainer : Form
    {
        private readonly HttpTrainerHandler _trainer;
        private string _apiUrl = "https://localhost:7160/api/Auth/register/trainer";
        private Guid? _selectedTrainerId = null;
        public Trainer()
        {
            InitializeComponent();
            _trainer = new HttpTrainerHandler();
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

            bool isSuccess = await _trainer.AddTrainerAsync(_apiUrl, trainerCreateDto);

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
            if (_selectedTrainerId.HasValue)
            {
                var trainerCreateDto = new TrainerCreateDto
                {
                    //Id = _selectedTrainerId.Value,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Age = string.IsNullOrWhiteSpace(txtAge.Text) ? 0 : Convert.ToInt32(txtAge.Text),
                    Gender = cmbGender.SelectedItem?.ToString(),
                    DateOfBirth = DTPDOB.Value,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Address = txtAddress.Text,
                    IsActive = ChkIsActive.Checked,
                    Schedule = cmbSchedule.SelectedItem?.ToString(),
                    Specialization = cmbSpecialization.SelectedItem?.ToString(),
                    TotalExperience = string.IsNullOrWhiteSpace(txtExperince.Text) ? 0 : Convert.ToInt32(txtExperince.Text),
                    Shift = txtShift.Text
                };

                string fullUrl = $"{_apiUrl}{_selectedTrainerId.Value}";

                bool isSuccess = await _trainer.UpdateTrainerAsync(fullUrl, trainerCreateDto);

                if (isSuccess)
                {
                    MessageBox.Show("RoomType updated successfully!");
                    LoadTrainers();

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
            private async void LoadTrainers()
            {
                try
                {
                    var Trainers = await _trainer.GetAllTrainersAsync(_apiUrl);

                    if (Trainers != null)
                    {
                    DGVTrainer.DataSource = Trainers;
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
    }
}
