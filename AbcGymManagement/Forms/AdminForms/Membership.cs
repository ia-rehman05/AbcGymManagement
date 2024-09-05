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
    public partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
            LoadMembershipSchemes();
        }

        private void LoadMembershipSchemes()
        {
            cmbScheme.Items.Add("Basic");
            cmbScheme.Items.Add("Premium");
            cmbScheme.Items.Add("VIP");
        }
        private void DisplaySchemeDetails(string scheme)
        {
            // Sample logic to display scheme details
            switch (scheme)
            {
                case "Basic":
                    txtAmout.Text = "1500";
                    txtDuration.Text = "1 Month";
                    // Set other details
                    break;
                case "Premium":
                    txtAmout.Text = "4000";
                    txtDuration.Text = "3 Months";
                    // Set other details
                    break;
                case "VIP":
                    txtAmout.Text = "100,000";
                    txtDuration.Text = "1 Year";
                    // Set other details
                    break;
            }
        }
    
    private void cmbScheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedScheme = cmbScheme.SelectedItem.ToString();
            DisplaySchemeDetails(selectedScheme);
        }
        private void lblMemberName_Click(object sender, EventArgs e)
        {

        }

        private void Membership_Load(object sender, EventArgs e)
        {

        }

        
    }
}
