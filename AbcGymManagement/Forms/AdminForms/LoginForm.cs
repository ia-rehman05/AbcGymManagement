using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMS.Service.Dtos.Login;

namespace AbcGymManagement.Forms.AdminForms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://localhost:7160/api/auth/login");
            var request = new RestRequest();
            request.AddQueryParameter("SortBy", "CreatedDate");
            request.AddQueryParameter("IsAscending", false);

            request.AddJsonBody(new
            {
                Email = txtEmail.Text,  
                Password = txtPassword.Text 
            });

            request.Method = Method.Post;

            try
            {
                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponseDto>(response.Content);
                    string jwtToken = loginResponse.JwtToken;

                    MessageBox.Show("Login successful!");

                    LoadDashboard(jwtToken);
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadDashboard(string jwtToken)
        {
            Dashboard dashboard = new Dashboard(jwtToken);
            dashboard.Show();
            this.Hide();
        }


        private void LblRegister_Click(object sender, EventArgs e)
        {

        }

    }
}
