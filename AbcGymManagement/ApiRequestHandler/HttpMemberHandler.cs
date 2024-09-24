using AbcGymManagement.Forms;
using GMS.Service.Dtos.Members;
using GMS.Service.Dtos.Packages;
using GMS.Service.Dtos.Room;
using GMS.Service.Dtos.Trainers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpMembertHandler
    {
        private readonly HttpClient _memberClient;

        public HttpMembertHandler(string baseAddress)
        {
            _memberClient = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _memberClient.DefaultRequestHeaders.Accept.Clear();
            _memberClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Add Member
        public async Task<bool> AddMemberAsync(string fullUrl, MemberCreatedDto memberCreateDto)
        {
            var jsonContent = JsonConvert.SerializeObject(memberCreateDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _memberClient.PostAsync(fullUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MemberResponseDto>>(responseContent);
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
    #region Update Member
    public async Task<bool> UpdateMemberAsync(string fullUrl, MemberCreatedDto memberDto)
        {
            var jsonContent = JsonConvert.SerializeObject(memberDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _memberClient.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MemberCreatedDto>>(responseContent);
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
        #region Get All Members
        public async Task<List<MemberResponseDto>> GetAllMembersAsync(string relativeUrl)
        {
            try
            {
                HttpResponseMessage response = await _memberClient.GetAsync(relativeUrl);
                Console.WriteLine($"Request URL: {relativeUrl}");
                Console.WriteLine($"Response Status: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response Content: {responseContent}");

                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<MemberResponseDto>>(responseContent);
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
        #region Delete Member
        public async Task<bool> DeleteMemberAsync(string fullUrl)
        {
            if (string.IsNullOrEmpty(fullUrl))
            {
                throw new ArgumentNullException(nameof(fullUrl), "The full URL cannot be null or empty.");
            }

            try
            {
                HttpResponseMessage response = await _memberClient.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MemberResponseDto>>(responseContent);
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
