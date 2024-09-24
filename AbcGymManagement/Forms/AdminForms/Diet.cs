using AbcGymManagement.ApiRequestHandler;
using GMS.Service.Dtos.Diets;
using GMS.Service.Dtos.Inventory;
using GMS.Service.Dtos.InventoryItems;
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
    public partial class Diet : Form
    {
        private readonly ApiCrudHandler<DietDto, UpdateDietDTO> _httpCrudRequest;

        private readonly HttpMembertHandler _memberHandler;

        public Diet()
        {
            InitializeComponent();
            _memberHandler = new HttpMembertHandler("https://localhost:7160/api/");
            LoadMembers();

        }
        private async void LoadMembers()
        {
            var members = await _memberHandler.GetAllMembersAsync("Member");
            cmbMembers.DataSource = members;
            cmbMembers.DisplayMember = "FirstName";  
            cmbMembers.ValueMember = "Id";
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Diet_Load(object sender, EventArgs e)
        {

        }
    }
}
