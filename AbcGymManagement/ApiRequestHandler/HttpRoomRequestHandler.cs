using AbcGymManagement.Forms.AdminForms;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{

    public class HttpRoomRequestHandler
    {
        #region field and Constructor
        private readonly HttpClient _client;

        public HttpRoomRequestHandler()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Post Room
        public async Task<bool> AddRoomTypeAsync(string fullUrl, RoomTypeDto roomTypeDto)
        {
            var jsonContent = JsonConvert.SerializeObject(roomTypeDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PostAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                    //var responseContent = await response.Content.ReadAsStringAsync();
                    //var apiResponse = JsonConvert.DeserializeObject<RoomResponse>(responseContent);
                    //return apiResponse? .Success ?? false;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }

        }
        #endregion

        #region Search Room by Id
        public async Task<RoomTypeDto> GetRoomTypeByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<RoomTypeDto>>(jsonContent);
                    return apiResponse.Success ? apiResponse.Data : null;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }
        #endregion

        #region Update Room
        public async Task<bool> UpdateRoomTypeAsync(string fullUrl, RoomTypeDto roomTypeDto)
        {
            var jsonContent = JsonConvert.SerializeObject(roomTypeDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<RoomTypeDto>>(responseContent);
                    return apiResponse.Success;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Delete Room
        public async Task<bool> DeleteRoomTypeByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Get All Rooms
        public async Task<List<RoomTypeDto>> GetAllRoomTypesAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<RoomTypeDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get room types from the API.");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return null;
            }
        }

        #endregion

    }
}


