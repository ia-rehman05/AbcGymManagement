using GMS.Service.Dtos.Feedback;
using GMS.Service.Dtos.Halls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpFeedbackHandler
    {
        #region field and Con
        private readonly HttpClient _feedback;

        public HttpFeedbackHandler(string baseAddress)
        {
            _feedback = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _feedback.DefaultRequestHeaders.Accept.Clear();
            _feedback.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion

        #region  Post Feedback
        public async Task<bool> PostFeedbackAsync(string fullUrl, FeedbackDto feedbackDto)
        {
            var jsonContent = JsonConvert.SerializeObject(feedbackDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _feedback.PostAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<FeedbackDto>>(responseContent);
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
        #region Get All Halls
        public async Task<List<FeedbackDto>> GetAllFeedbacksAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _feedback.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<FeedbackDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Feedbacks from the API.");
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
        #region Update Feedback
        public async Task<bool> UpdateFeedbackAsync(string fullUrl, FeedbackDto feedbackDto)
        {
            var jsonContent = JsonConvert.SerializeObject(feedbackDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _feedback.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<FeedbackDto>>(responseContent);
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
        #region DeleteFeedback
        public async Task<bool> DeleteFeedackByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _feedback.DeleteAsync(fullUrl);

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
