using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace AbcGymManagement.SignalR
{
    public class SignalRClientHandler<TEntity>
    {
        private HubConnection _hubConnection;
        private readonly string _hubUrl;
        private readonly string _entityName;
        private readonly Action _refreshCallback;

        public SignalRClientHandler(string hubUrl, string entityName, Action refreshCallback)
        {
            _hubUrl = hubUrl;
            _entityName = entityName;
            _refreshCallback = refreshCallback;
        }

        public async Task StartConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_hubUrl)
                .WithAutomaticReconnect()
                .Build();

            // Subscribing to SignalR messages
            _hubConnection.On<string>($"{_entityName}Added", message =>
            {
                RefreshDataGrid();
            });

            _hubConnection.On<string>($"{_entityName}Updated", message =>
            {
                RefreshDataGrid();
            });

            _hubConnection.On<string>($"{_entityName}Deleted", message =>
            {
                RefreshDataGrid();
            });

            try
            {
                await _hubConnection.StartAsync();
                MessageBox.Show($"Connected to {_entityName} SignalR Hub");
                //RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SignalR Connection Error: {ex.Message}");
            }
        }
        private void RefreshDataGrid()
        {
            // Invoke the refresh callback on the UI thread
            if (Application.OpenForms.OfType<Form>().Any())
            {
                var form = Application.OpenForms.OfType<Form>().First();
                form.Invoke(new Action(() =>
                {
                    _refreshCallback?.Invoke(); // Refreshes the DataGridView or other controls
                }));
            }
        }
        public async Task StopConnection()
        {
            if (_hubConnection != null)
            {
                await _hubConnection.StopAsync();
                await _hubConnection.DisposeAsync();
            }
        }

    }
}
