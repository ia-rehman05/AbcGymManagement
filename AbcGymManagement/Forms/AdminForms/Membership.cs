using AbcGymManagement.ApiRequestHandler;
using AbcGymManagement.Dtos.Memberships;
using GMS.Service.Dtos.Members;
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
using System.Xml.Linq;

namespace AbcGymManagement.Forms
{
    public partial class Membership : Form
    {
        private readonly HttpMembershipHandler _membershipHandler;
        private readonly HttpMembertHandler _memberHandler;
        private readonly HttpPackageHandler _packageHandler;
        private string _apiUrl = "https://localhost:7160/api/Membership";
        private string _packageUrl = "https://localhost:7160/api/Package";

        private Guid? _selectedMembershipId = null;


        public Membership()
        {
            InitializeComponent();
            _membershipHandler = new HttpMembershipHandler("https://localhost:7160/api/");
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");
            _packageHandler = new HttpPackageHandler("https://localhost:7160/api/");

            LoadMembers();
            LoadPackages();
            LoadMemership();
        }

        private async void LoadMembers()
        {
            var members = await _memberHandler.GetAllMembersAsync("Member");
            cmbMember.DataSource = members;
            cmbMember.DisplayMember = "FirstName";
            cmbMember.ValueMember = "Id";
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var membershipdto = new MembershipCreatedDto()
            {
                MemberId = cmbMember.SelectedValue.ToString(),
                PackageId = (Guid?)cmbPackage.SelectedValue,
                IsActive = ChkIsActive.Checked
            };
            bool isSuccess = await _membershipHandler.AddMembershipAsync(_apiUrl, membershipdto);

            if (isSuccess)
            {
                MessageBox.Show("Membership added successfully!");
                LoadMemership();
            }
            else
            {
                MessageBox.Show("Failed to add Membership.");
            }
        }


        private async void LoadMemership()
        {
            try
            {
                var membership = await _membershipHandler.GetAllMembershipsAsync(_apiUrl);

                if (membership != null)
                {
                    DGVMembership.DataSource = membership;
                }
                else
                {
                    MessageBox.Show("Failed to Load membership.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}");
            }
        }
        private async void LoadPackages()
        {
            var package = await _packageHandler.GetAllpackagesAsync(_packageUrl);
            cmbPackage.DataSource = package;
            cmbPackage.DisplayMember = "Name";
            cmbPackage.ValueMember = "Id";
        }


        private void cmbScheme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblMemberName_Click(object sender, EventArgs e)
        {

        }

        private void Membership_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGVMembership_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DGVMembership.SelectedRows.Count > 0)
            {
                var selectedRow = DGVMembership.SelectedRows[0];
                _selectedMembershipId = (Guid)selectedRow.Cells["Id"].Value;
                cmbMember.SelectedValue = selectedRow.Cells["MemberId"].Value.ToString();
                cmbPackage.SelectedValue = selectedRow.Cells["PackageId"].Value;
                ChkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedMembershipId.HasValue)
            {
                string fullUrl = $"{_apiUrl}/{_selectedMembershipId.Value}";

                bool isSuccess = await _membershipHandler.DeleteMembershipByIdAsync(fullUrl);

                if (isSuccess)
                {
                    MessageBox.Show("Membership deleted successfully!");
                    LoadMemership();
                }


                else
                {
                    MessageBox.Show("Failed to delete Membership.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Membership to delete.");
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (_selectedMembershipId.HasValue)
            {
                var updatedmembership = new MembershipResponseDto
                {
                    MemberId = cmbMember.SelectedValue.ToString(),
                    PackageId = (Guid?)cmbPackage.SelectedValue,
                    IsActive = ChkIsActive.Checked
                };

                string fullUrl = $"{_apiUrl}/{_selectedMembershipId.Value}";
                bool isSuccess = await _membershipHandler.UpdateMembershipAsync(fullUrl, updatedmembership);

                if (isSuccess)
                {
                    MessageBox.Show("MemberShip updated successfully!");
                    LoadMemership();

                }
                else
                {
                    MessageBox.Show("Failed to update Memberhip.");
                }
            }
            else
            {
                MessageBox.Show("Please select a Membership to update.");
            }
        }
    }
}
