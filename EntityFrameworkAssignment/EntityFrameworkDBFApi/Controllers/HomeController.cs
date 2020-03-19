using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkDBFApi.CustomViewModels;
using EntityFrameworkDBFApi.Models.entityModels;
using EntityFrameworkDBFApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkDBFApi.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;
        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        /// Get:GetAllData
        /// <summary>
        /// This method getting all the information
        /// </summary>
        /// <returns>List</returns>
        [HttpGet]
        public async Task<IActionResult> GetCustomerOrder()
        {
            var response =await _customerRepository.GetAllData();
            return Ok(response);
        }

        /// Get:SingleData
        /// <summary>
        /// this method getting the particular data
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List</returns>
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetSingleData(int id)
        {
            try
            {
                var response = await _customerRepository.SingleData(id);
                return Ok(response);

            }
            catch (Exception ex)
            {

                throw ex;
            }   
        }

        /// Post:InsertData
        /// <summary>
        /// This method inserting the data
        /// </summary>
        /// <param name="cust"></param>
        /// <returns>boolean</returns>
        [HttpPost]
        public async Task<IActionResult> PostData(CustomerViewModel cust )
        {
            try
            {
                var response = await _customerRepository.InsertData(cust);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// Put:UpdateData
        /// <summary>
        /// This method Updating the data
        /// </summary>
        /// <param name="cust"></param>
        /// <returns>Boolean</returns>
        [HttpPut]
        public async Task<IActionResult> PutData(CustomerViewModel cust)
        {
            try
            {
                var response = await _customerRepository.UpdateData(cust);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// Delete:
        /// <summary>
        /// This method delete the customer data
        /// </summary>
        /// <returns>Boolean</returns>
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteData(int id)
        {
            try
            {
                var response = await _customerRepository.DeleteData(id);
                return Ok(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}