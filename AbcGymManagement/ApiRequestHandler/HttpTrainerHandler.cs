using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Room;
using GMS.Service.Dtos.Trainers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpTrainerHandler
    {
        private readonly HttpClient _trainer;

        public HttpTrainerHandler(string baseAddress)
        {
            _trainer = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _trainer.DefaultRequestHeaders.Accept.Clear();
            _trainer.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #region Post Trainer
        public async Task<bool> AddTrainerAsync(string fullUrl, TrainerCreateDto trainerCreateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(trainerCreateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _trainer.PostAsync(fullUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TrainerResponseDto>>(responseContent);
                    return apiResponse.Success;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    return false;
                    //string responseContent = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine($"Error: {response.StatusCode}, {responseContent}");
                    //return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return false;
            }
        
    }


        #endregion

        #region Update Trainer
        public async Task<bool> UpdateTrainerAsync(string fullUrl, TrainerCreateDto trainerCreateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(trainerCreateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            try
            {
                HttpResponseMessage response = await _trainer.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<TrainerResponseDto>>(responseContent);
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

        #region Get All 
        public async Task<List<TrainerResponseDto>> GetAllTrainersAsync(string relativeUrl)
        {
            try
            {
                HttpResponseMessage response = await _trainer.GetAsync(relativeUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<TrainerResponseDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Trainers from the API.");
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

        #region Delete Trainer
        public async Task<bool> DeleteTrainerAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _trainer.DeleteAsync(fullUrl);

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

    }
}
