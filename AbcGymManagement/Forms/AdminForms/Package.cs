using AbcGymManagement.ApiRequestHandler;
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
        private readonly HttpHallRequestHandler _httpPackage;
        private string _apiUrl = "https://localhost:7160/api/Package";
        private Guid? _selectedHallId = null;
        public Package()
        {
            InitializeComponent();
            _httpPackage = new HttpHallRequestHandler("https://localhost:7160/"); 

        }

        private void Package_Load(object sender, EventArgs e)
        {

        }
    }
}
