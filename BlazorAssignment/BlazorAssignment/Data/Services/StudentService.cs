using BlazorAssignment.Data.Respository;
using BlazorAssignment.Library.Models.entityModels;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorAssignment.Data.Services
{

    public class StudentService : IStudentRepository
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient )
        {
            this.httpClient = httpClient;
        }
        /// <summary>
        /// This method all details of the student
        /// </summary>
        /// <returns>student list</returns>
        public List<TblStudent> StudentDetail()
        {
            var responsedata = httpClient.GetStringAsync("http://localhost:52018/api/Student");
            return JsonConvert.DeserializeObject<List<TblStudent>>(responsedata.Result);


        }

        public bool InsertStudent(TblStudent student)
        {
            var responsedata = httpClient.PostJsonAsync<List<TblStudent>>("http://localhost:52018/api/Student", student);
            return true;
        }

        public TblStudent StudentById(string sid)
        {
            int id = Convert.ToInt32(sid);
            var responsedata = httpClient.GetStringAsync("http://localhost:52018/api/Student/"+id);
            return JsonConvert.DeserializeObject<TblStudent>(responsedata.Result);

        }

        public bool UpdateStudent(string sid,TblStudent student)
        {
            int id = Convert.ToInt32(sid);
            var responsedata = httpClient.PutJsonAsync<List<TblStudent>>("http://localhost:52018/api/Student/"+id, student);
            return true;
        }

        public bool DeleteStudent(int id)
        {
            var responsedata = httpClient.DeleteAsync("http://localhost:52018/api/Student/" + id);
            return true;
        }
    }
}
