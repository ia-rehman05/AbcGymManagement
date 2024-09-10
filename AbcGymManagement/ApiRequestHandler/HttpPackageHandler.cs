using GMS.Service.Dtos.Halls;
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

        
    }
}
