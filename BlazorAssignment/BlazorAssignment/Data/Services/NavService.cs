using BlazorAssignment.Data.Respository;
using BlazorAssignment.Library.Models.entityModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Services
{
    public class NavService : INavRepository
    {
        private readonly HttpClient httpClient;

        public NavService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public List<TblNavData> GetNavDatas()
        {
            var responsedata = httpClient.GetStringAsync("http://localhost:52018/api/NavBar");
            return JsonConvert.DeserializeObject<List<TblNavData>>(responsedata.Result);

        }
    }
}
