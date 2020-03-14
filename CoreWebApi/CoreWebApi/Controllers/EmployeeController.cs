using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Data;
using CoreWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApi.Controllers
{
    [Route("api/[controller]/{Action}")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeOperations _IEmployeeOperations;
        public EmployeeController(IEmployeeOperations EmployeeOperations)
        {
            _IEmployeeOperations = EmployeeOperations;
        }
        /// <summary>
        /// Employee 
        /// </summary>
        /// <returns></returns>
        public IActionResult GetEmployeeData()
        {
            DataSet empdataset = _IEmployeeOperations.GetEmployee();
            return Ok(empdataset);
        }
        /// <summary>
        /// Here Getting Single user Data
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public IActionResult PostSingleData(EmployeeModel emp)
        {
            DataSet dataSet = _IEmployeeOperations.GetEmp(emp);
            return Ok(dataSet);
        }
        /// <summary>
        /// Insert Employee Data
        /// </summary>
        /// <param name="emp"></param>
        /// <returns>bBool</returns>
        public IActionResult PostData(EmployeeModel emp)
        {
            bool response = _IEmployeeOperations.PostInsert(emp);
            return Ok(response);
        }

       /// <summary>
       /// Update Employee Information 
       /// </summary>
       /// <param name="emp"></param>
       /// <returns>Bool</returns>
        public IActionResult PutData(EmployeeModel emp)
        {
            bool response = _IEmployeeOperations.PutEmp(emp);
            return Ok(response);

        }
       /// <summary>
       /// Delete Employee Data from database
       /// </summary>
       /// <param name="emp"></param>
       /// <returns>Bool</returns>       
        public IActionResult DeleteData(EmployeeModel emp)
        {
            bool response = _IEmployeeOperations.DeleteEmp(emp);
            return Ok(response);
        }
    }
}