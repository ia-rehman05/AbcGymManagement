using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using RestSharp;
using System.Net.Http.Json;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpHallRequestHandler
    {
        #region field and Con
        private readonly HttpClient _client;

        public HttpHallRequestHandler(string baseAddress)
        {
            _client = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region  Post Hall
        public async Task<bool> PostHallAsync(string fullUrl, HallDto hallDto)
        {
            var jsonContent = JsonConvert.SerializeObject(hallDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PostAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<HallDto>>(responseContent);
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

            #region Update Hall
            public async Task<bool> UpdateHallAsync(string fullUrl, HallDto hallDto)
            {
                var jsonContent = JsonConvert.SerializeObject(hallDto);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await _client.PutAsync(fullUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();
                        var apiResponse = JsonConvert.DeserializeObject<ApiResponse<HallDto>>(responseContent);
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

        #region DeleteHall
        public async Task<bool> DeleteHallByIdAsync(string fullUrl)
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

        #region Get All Halls
        public async Task<List<HallDto>> GetAllHallsAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<HallDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Hall from the API.");
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

        #region populate Room in Form
        public async Task<List<RoomTypeDto>> GetRoomTypesAsync(string url)
        {
            try
            {
                var fullUrl = new Uri(new Uri(_client.BaseAddress.ToString()), url).ToString();
                Console.WriteLine($"Fetching Room Types from: {fullUrl}");

                var response = await _client.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var roomTypeResponse = JsonConvert.DeserializeObject<ApiListResponse<RoomTypeDto>>(json);

                    if (roomTypeResponse != null && roomTypeResponse.Success)
                    {
                        return roomTypeResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Error: API response was unsuccessful.");
                        return new List<RoomTypeDto>();
                    }
                }
                else
                {
                    Console.WriteLine($"Error fetching room types: {response.StatusCode} - {response.ReasonPhrase}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                throw;
            }
        }
        #endregion
        #region not used methods
        public RestResponse SendRequestAsync(string endpoint, Method method, object body = null)
        {
            var options = new RestClientOptions("https://localhost:7160")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest(endpoint, method);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }

        private async Task<ApiResponse<T>> HandleResponse<T>(HttpResponseMessage response)
        {
            var result = new ApiResponse<T>
            {
                Success = response.IsSuccessStatusCode,
                StatusCode = (int)response.StatusCode,
                Data = default,
                Errors = new List<string>()
            };

            if (response.IsSuccessStatusCode)
            {
                result.Data = await response.Content.ReadFromJsonAsync<T>();
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                result.Errors.Add(error);
            }

            return result;
        }
        #endregion
    }
}
