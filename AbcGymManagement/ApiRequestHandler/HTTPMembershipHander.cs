using AbcGymManagement.Dtos.Memberships;
using GMS.Service.Dtos.Packages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpMembershipHandler
    {
        private readonly HttpClient _membership;

        public HttpMembershipHandler(string baseAddress)
        {
            _membership = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _membership.DefaultRequestHeaders.Accept.Clear();
            _membership.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #region Add Membership
        public async Task<bool> AddMembershipAsync(string fullUrl, MembershipCreatedDto membershipDto)
        {
            var jsonContent = JsonConvert.SerializeObject(membershipDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _membership.PostAsync(fullUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MembershipResponseDto>>(responseContent);
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
        #region DeleteMembership
        public async Task<bool> DeleteMembershipByIdAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _membership.DeleteAsync(fullUrl);

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

        #region Update Room
        public async Task<bool> UpdateMembershipAsync(string fullUrl, MembershipResponseDto membershipResponse)
        {
            var jsonContent = JsonConvert.SerializeObject(membershipResponse);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _membership.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<MembershipResponseDto>>(responseContent);
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

        #region Get All Memberships
        public async Task<List<MembershipResponseDto>> GetAllMembershipsAsync(string relativeUrl)
        {
            try
            {
                HttpResponseMessage response = await _membership.GetAsync(relativeUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<MembershipResponseDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Memberships from the API.");
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
