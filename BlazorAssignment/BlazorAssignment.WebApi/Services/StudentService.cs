using BlazorAssignment.Library.Models.entityModels;
using BlazorAssignment.WebApi.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAssignment.WebApi.Services
{
    public class StudentService : IStudentRepository
    {
		//This is the dependency injection of Dbcontext
		StudentDBContext _studentDBContext;
		public StudentService()
		{
			_studentDBContext = new StudentDBContext();
		}

		/// DELETE:DeleteStudent
		/// <summary>
		///This method deleting the student by studentid
		/// </summary>
		/// <param name="studentid"></param>
		public async Task<TblStudent> DeleteStudent(int studentid)
		{
			var response = await _studentDBContext.TblStudent.FirstOrDefaultAsync
						   (s => s.StudentId == studentid);
			if (response != null)
			{
				_studentDBContext.TblStudent.Remove(response);
				await _studentDBContext.SaveChangesAsync();
				return response;
			}
			return null;
		}

		/// PUT:EditStudent
		/// <summary>
		/// This method Update the student Detail
		/// </summary>
		/// <param name="student"></param>
		/// <returns></returns>
		public async Task<TblStudent> EditStudent(TblStudent student)
		{
			var response =await  _studentDBContext.TblStudent.FirstOrDefaultAsync
							(s=>s.StudentId==student.StudentId);
			if (response != null)
			{
				response.StudentName = student.StudentName;
				response.StudentCourse = student.StudentCourse;
				response.StudentGender = student.StudentGender;
				response.StudentEmail = student.StudentEmail;
				response.StudentPhone = student.StudentPhone;
				response.StudentAddress = student.StudentAddress;

				await _studentDBContext.SaveChangesAsync();
				return response;
			}
			else
			{
				return null;
			}
		}

		/// GET:GetStudent
		/// <summary>
		/// This method showing all the details student
		/// </summary>
		/// <returns>Tblstudent</returns>
		public async Task<IEnumerable<TblStudent>> GetStudent()
        {
			
				return await _studentDBContext.TblStudent.ToListAsync();
			
        }

		/// GET:GetStudentById
		/// <summary>
		/// This method showing the particular student detail
		/// </summary>
		/// <param name="studentId"></param>
		/// <returns>studentmodel</returns>
		public async Task<TblStudent> GetStudentById(int studentId)
		{
			return await _studentDBContext.TblStudent.FirstOrDefaultAsync(s=>s.StudentId== studentId);
		}

		/// POST:InsertStudent
		/// <summary>
		/// This method adding/ insert new student
		/// </summary>
		/// <param name="student"></param>
		/// <returns>studentmodel</returns>
		public async Task<TblStudent> InsertStudent(TblStudent student)
		{
			var response = await _studentDBContext.TblStudent.AddAsync(student);
			await _studentDBContext.SaveChangesAsync();
			return response.Entity;
		}
	}
}
