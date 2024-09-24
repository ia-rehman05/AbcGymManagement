using AbcGymManagement.Forms;
using GMS.Service.Dtos.Attendances;
using GMS.Service.Dtos.InventoryItems;
using GMS.Service.Dtos.Members;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    internal class ApiCrudHandler<TDto, TResponseDto>
        {
            private readonly HttpClient _client;

            public ApiCrudHandler(string baseAddress)
            {
                _client = new HttpClient { BaseAddress = new Uri(baseAddress) };
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

        #region Create (Add)
        public async Task<bool> AddAsync(string fullUrl, TDto dto)
            {
                var jsonContent = JsonConvert.SerializeObject(dto);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await _client.PostAsync(fullUrl, content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TResponseDto>>(responseContent);
                        return apiResponse.Success;
                    }
                    else
                    {
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

        #region Read (Get All)
        public async Task<List<TResponseDto>> GetAllAsync(string relativeUrl)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(relativeUrl);
                Console.WriteLine($"Request URL: {relativeUrl}");
                Console.WriteLine($"Response Status: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Content: {responseContent}");

                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<TResponseDto>>(responseContent);
                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Members from the API.");
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

        #region Update
        public async Task<bool> UpdateAsync(string fullUrl, TResponseDto responseDto)
        {
            var jsonContent = JsonConvert.SerializeObject(responseDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _client.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TResponseDto>>(responseContent);
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


        #region Delete
        public async Task<bool> DeleteByIdAsync(string fullUrl)
            {
          
                if (string.IsNullOrEmpty(fullUrl))
                {
                    throw new ArgumentNullException(nameof(fullUrl), "The full URL cannot be null or empty.");
                }

            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TResponseDto>>(responseContent);
                    return apiResponse?.Success ?? false;
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
        }
    }

