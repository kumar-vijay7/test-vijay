using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAssignment.Library.Models.entityModels;
using BlazorAssignment.WebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAssignment.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        /// GET:GetStudent
        /// <summary>
        /// This method showing all the details of the student
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetStudent()
        {
            try
            {
                return Ok(await _studentRepository.GetStudent());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Oops! Internal Server Error");
            }
        }
        /// GET:GetStudentById
        /// <summary>
        /// This method showing the detail of particular student
        /// </summary>
        /// <param name="id"></param>
        /// <returns>studentModel</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TblStudent>> GetStudentById(int id)
        {
            try
            {
                var response = await _studentRepository.GetStudentById(id);
                if (response == null)
                {
                    return NotFound();
                }
                return response;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Oops! Internal Server Error");
            }
        }
        /// POST:PostStudent
        /// <summary>
        /// This method inserting new student in DB
        /// </summary>
        /// <param name="student"></param>
        /// <returns>studentmodel</returns>
        [HttpPost]
        public async Task<ActionResult<TblStudent>> PostStudent(TblStudent student)
        {
            try
            {
                if (student == null)
                {
                    return BadRequest();
                }
                var insertstudent = await _studentRepository.InsertStudent(student);
                return CreatedAtAction(nameof(GetStudent), new { id = insertstudent.StudentId }, insertstudent);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                      "Oops! Internal Server Error");
            }
        }

        /// PUT:PutStudentDetail/EditStudent
        /// <summary>
        /// This method updating the student detail
        /// </summary>
        /// <param name="id"></param>
        /// <param name="student"></param>
        /// <returns>student model</returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult<TblStudent>> PutStudentDetail(int id, TblStudent student)
        {
            try
            {
                if (id != student.StudentId)
                {
                    return BadRequest("Student Detaile Not Found");
                }
                var response = await _studentRepository.GetStudentById(id);
                if (response == null)
                {
                    return NotFound($"Student not found with id={id}");
                }
                return await _studentRepository.EditStudent(student);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                     "Oops! Internal Server Error");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TblStudent>> DeleteStudentById(int id)
        {
            
            return await _studentRepository.DeleteStudent(id);
        }
    }
}