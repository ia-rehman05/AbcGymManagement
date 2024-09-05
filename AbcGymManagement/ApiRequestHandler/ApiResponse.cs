using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcGymManagement.ApiRequestHandler
{
    public class ApiListResponse<T>
    {
        public bool Success { get; set; }
        public List<T> Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
    }
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
    }
}