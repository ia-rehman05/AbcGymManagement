using AbcGymManagement.Forms;
using GMS.Service.Dtos.Attendances;
using GMS.Service.Dtos.Halls;
using GMS.Service.Dtos.Members;
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
    public class HttpAttendaneHandler
    {
        #region field and Con
        private readonly HttpClient _attendance;

        public HttpAttendaneHandler(string baseAddress)
        {
            _attendance = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _attendance.DefaultRequestHeaders.Accept.Clear();
            _attendance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion
        #region Add Attendance
        public async Task<bool> AddAttendanceAsync(string fullUrl, AttendanceDto attendanceDto)
        {
            var jsonContent = JsonConvert.SerializeObject(attendanceDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _attendance.PostAsync(fullUrl, content);
                var responseContent = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = JsonConvert.DeserializeObject<ApiListResponse<AttendanceDto>>(responseContent);
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

        #region Get All Attendance  
        public async Task<List<AttendanceDto>> GetAttendancesAsync(string fullUrl)
        {
            try
            {
                HttpResponseMessage response = await _attendance.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    var apiListResponse = JsonConvert.DeserializeObject<ApiListResponse<AttendanceDto>>(responseContent);

                    if (apiListResponse != null && apiListResponse.Success)
                    {
                        return apiListResponse.Data;
                    }
                    else
                    {
                        Console.WriteLine("Failed to get Attendance from the API.");
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

        #region Delete Attendance
        public async Task<bool> DeleteAttendanceAsync(string fullUrl)
        {
            if (string.IsNullOrEmpty(fullUrl))
            {
                throw new ArgumentNullException(nameof(fullUrl), "The full URL cannot be null or empty.");
            }

            try
            {
                HttpResponseMessage response = await _attendance.DeleteAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<AttendanceDto>>(responseContent);
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

        #region Update Attendance
        public async Task<bool> UpdateAttendanceAsync(string fullUrl, AttendanceDto attendanceDto)
        {
            var jsonContent = JsonConvert.SerializeObject(attendanceDto);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _attendance.PutAsync(fullUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse<AttendanceDto>>(responseContent);
                    ApiResponse<AttendanceDto>? apiResponse1 = apiResponse;
                    return apiResponse1.Success;
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
