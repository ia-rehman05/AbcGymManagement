using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Feedback;
using GMS.Service.Dtos.Halls;
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
    public partial class FeedBack : Form
    {
        private readonly HttpFeedbackHandler _httpFeedback;
        private readonly HttpMembertHandler _memberHandler;
        private string _apiUrl = "https://localhost:7160/api/Feedback";
        private Guid? _selectedFeedbackId = null;
        public FeedBack()
        {
            InitializeComponent();
            _httpFeedback = new HttpFeedbackHandler("https://localhost:7160/"); // Base URL for the API
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");
            LoadMembers();
            LoadFeedback();

        }
        private async void LoadMembers()
        {
            var members = await _memberHandler.GetAllMembersAsync("Member");
            cmbMember.DataSource = members;
            cmbMember.DisplayMember = "FirstName";
            cmbMember.ValueMember = "Id";
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedFeedbackId.HasValue)
            {
                var updatedfeedback = new FeedbackDto
                {
                    Id = _selectedFeedbackId.Value,
                    Date = dtpDate.Value,
                    FeedbackType = cmbType.Text,
                    Description = txtDescription.Text,
                    ResolutionStatus = cmbStatus.Text,
                };

                string fullUrl = $"{_apiUrl}/{_selectedFeedbackId.Value}";
                bool isSuccess = await _httpFeedback.UpdateFeedbackAsync(fullUrl, updatedfeedback);

                if (isSuccess)
                {
                    MessageBox.Show("Feedback updated successfully!");
                    LoadFeedback();

                }
                else
                {
                    MessageBox.Show("Failed to update Feedback.");
                    LoadFeedback();
                }
            }
            else
            {
                MessageBox.Show("Please select a Feedback to update.");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (_selectedFeedbackId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedFeedbackId.Value}";
                bool isSuccess = await _httpFeedback.DeleteFeedackByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Feedback deleted successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to Feedback Hall.");
                }
                LoadFeedback();
            }
            else
            {
                MessageBox.Show("Please select a Feedback to delete.");
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var feedbackdto = new FeedbackDto
            {
                Id = _selectedFeedbackId ?? Guid.NewGuid(),
                Date = dtpDate.Value,
                FeedbackType = cmbType.Text,
                Description = txtDescription.Text,
                ResolutionStatus = cmbStatus.Text,

                MemberId = cmbMember.SelectedValue.ToString(),

            };

            bool isSuccess = await _httpFeedback.PostFeedbackAsync(_apiUrl, feedbackdto);

            if (isSuccess)
            {
                MessageBox.Show($"Feedback Added successfully.");
                LoadFeedback();
            }
            else
            {
                MessageBox.Show("Failed to add Feedback.");

            }
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }
       
        

        private async void LoadFeedback()
        {
            try
            {
                var feedBack = await _httpFeedback.GetAllFeedbacksAsync(_apiUrl);

                if (feedBack != null)
                {
                    DGVFeedback.DataSource = feedBack;
                }
                else
                {
                    MessageBox.Show("Failed to FeedBack.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
        private void DGVFeedback_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVFeedback.SelectedRows.Count > 0)
            {
                var selectedRow = DGVFeedback.SelectedRows[0];

                _selectedFeedbackId = (Guid)selectedRow.Cells["Id"].Value;
                cmbMember.SelectedValue = selectedRow.Cells["MemberId"].Value;

                dtpDate.Value = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                cmbType.SelectedItem = selectedRow.Cells["FeedbackType"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                cmbStatus.SelectedItem = selectedRow.Cells["ResolutionStatus"].Value.ToString();
            }
        }
    }
}
