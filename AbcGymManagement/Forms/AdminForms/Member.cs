using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.SignalR;
using GMS.Service.Dtos.Members;
using GMS.Service.Dtos.Trainers;
using Microsoft.AspNetCore.SignalR.Client;
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
    public partial class Member : Form
    {
        private readonly HttpMembertHandler _memberHandler;
        private readonly HttpTrainerHandler _trainerHandler;
        private readonly HttpMembershipHandler _membershipHandler;
        private HubConnection _hubConnection;
        private readonly SignalRClientHandler<Member> _signalRClientHandler;

        private string _apiUrl = "https://localhost:7160/api/Member";
        private string apiUrl = "https://localhost:7160/api/Membership";


        private Guid? _selectedMemberId = null;
        public Member()
        {
            InitializeComponent();
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");
            _trainerHandler = new HttpTrainerHandler("https://localhost:7160/api/");
            _membershipHandler = new HttpMembershipHandler("https://localhost:7160/api/");
            LoadMembers();
            LoadTrainers();
            LoadMemberships();
            //StartSignalRConnection();
            _signalRClientHandler = new SignalRClientHandler<Member>("https://localhost:7160/GymHub", "Member", LoadMembers);

            StartSignalR();


        }

        private async void StartSignalR()
        {
            await _signalRClientHandler.StartConnection();
        }
        private async void LoadTrainers()
        {
            var trainers = await _trainerHandler.GetAllTrainersAsync("Trainer");
            cmbTrainer.DataSource = trainers;
            cmbTrainer.DisplayMember = "FirstName";
            cmbTrainer.ValueMember = "Id";
        }

        private async void LoadMemberships()
        {
            var memberships = await _membershipHandler.GetAllMembershipsAsync(apiUrl);
            cmbMembershipID.DataSource = memberships;
            cmbTrainer.DisplayMember = "PackageId";
            cmbTrainer.ValueMember = "Id";
        }

        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void LblQuote_Click(object sender, EventArgs e)
        {

        }

        private void lblAddMember_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbMembershipID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var memberdto = new MemberCreatedDto()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                Age = string.IsNullOrWhiteSpace(txtAge.Text) ? 0 : Convert.ToInt32(txtAge.Text),
                Gender = cmbGender.SelectedItem?.ToString(),
                Address = txtAddress.Text,
                DateOfBirth = DTPDOB.Value,
                IsActive = ChkIsActive.Checked,

                TrainerId = cmbTrainer.SelectedValue.ToString(),
                MembershipId = (Guid?)cmbMembershipID.SelectedValue

            };
            string Url = "https://localhost:7160/api/Auth/register/member";
            bool isSuccess = await _memberHandler.AddMemberAsync(Url, memberdto);

            if (isSuccess)
            {
                MessageBox.Show("Member added successfully!");
                LoadMembers();
            }
            else
            {
                MessageBox.Show("Failed to add Member.");
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId != null)
            {
                var Updatemember = new MemberCreatedDto()
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Age = int.TryParse(txtAge.Text, out int age) ? age : 0,
                    Gender = cmbGender.SelectedItem?.ToString(),
                    Address = txtAddress.Text,
                    DateOfBirth = DTPDOB.Value,
                    IsActive = ChkIsActive.Checked,
                    TrainerId = cmbTrainer.SelectedValue?.ToString(),
                    MembershipId = cmbMembershipID.SelectedValue as Guid?

                };
                string fullUrl = $"{_apiUrl}/{_selectedMemberId.Value}";
                bool isSuccess = await _memberHandler.UpdateMemberAsync(fullUrl, Updatemember);

                if (isSuccess)
                {
                    MessageBox.Show("Member Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update Member");
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("Please Select Any Member First");
            }


        }
        private async void LoadMembers()
        {
            try
            {
                var members = await _memberHandler.GetAllMembersAsync("Member");

                if (members != null && members.Any())
                {
                    DGVMember.DataSource = members;


                }
                else
                {
                    MessageBox.Show("No Members found or failed to load Members.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }

        private void DGVMember_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVMember.SelectedRows.Count > 0)
            {
                var selectedRow = DGVMember.SelectedRows[0];

                _selectedMemberId = (Guid)selectedRow.Cells["Id"].Value;

                txtName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                cmbGender.SelectedItem = selectedRow.Cells["Gender"].Value?.ToString();
                DTPDOB.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                ChkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);

            }
        }


        private void DGVMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedMemberId.Value}";

                bool isSuccess = await _memberHandler.DeleteMemberAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Member deleted successfully!");
                    LoadMembers();
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

        private void cmbTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            _signalRClientHandler.StopConnection();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}