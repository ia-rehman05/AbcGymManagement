using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Members;
using GMS.Service.Dtos.Packages;
using GMS.Service.Dtos.Room;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class HttpPackageHandler
    {
        #region field and Con
        private readonly HttpClient _package;

        public HttpPackageHandler(string baseAddress)
        {
            _package = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _package.DefaultRequestHeaders.Accept.Clear();
            _package.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion
        #region Add Package
        public async Task<bool> AddPackageAsync(string fullUrl, PackageDto packageDto)
        {
            var jsonContent = JsonConvert.SerializeObject(packageDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _package.PostAsync(fullUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<PackageResponseDto>>(responseContent);
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

        #region Get All Members
        public async Task<List<PackageResponseDto>> GetAllpackagesAsync(string relativeUrl)
        {
            try
            {
                HttpResponseMessage response = await _package.GetAsync(relativeUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<PackageResponseDto>>(responseContent);

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

        #region DeletePackage
        public async Task<bool> DeletePackageByIdAsync(string fullUrl)
        {
            if (string.IsNullOrEmpty(fullUrl))
            {
                throw new ArgumentNullException(nameof(fullUrl), "The full URL cannot be null or empty.");
            }

            try
            {
                HttpResponseMessage response = await _package.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<PackageResponseDto>>(responseContent);
                    return apiResponse? .Success ?? false;
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

        #region Update Package
        public async Task<bool> UpdatePackageAsync(string fullUrl, PackageResponseDto packageresponsedto)
        {
            var jsonContent = JsonConvert.SerializeObject(packageresponsedto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _package.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<PackageResponseDto>>(responseContent);
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
    }
}
