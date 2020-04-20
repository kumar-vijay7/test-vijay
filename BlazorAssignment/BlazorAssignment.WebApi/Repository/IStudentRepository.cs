using BlazorAssignment.Library.Models.entityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.WebApi.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<TblStudent>> GetStudent();
        Task<TblStudent> GetStudentById(int studentId);
        Task<TblStudent> InsertStudent(TblStudent student);
        Task<TblStudent> EditStudent(TblStudent student);
        Task<TblStudent> DeleteStudent(int studentid);
    }
}
