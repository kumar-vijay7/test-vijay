using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SecurityProject.Models;
using SecurityProject.Models.Models;
using SecurityProject.Services;
using SecurityProject.Settings;

namespace SecurityProject.Controllers
{
    [Route("api/[controller]/{Action}")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly JwtSettings _jwt;

        /// <summary>
        /// HomeController Constructor
        /// </summary>
        /// <param name="loginService"></param>
        /// <param name="jwt"></param>
        public HomeController(ILoginService loginService, IOptions<JwtSettings> jwt)
        {
            _loginService = loginService;
            _jwt = jwt.Value;
        }


        ///POST:Authenticate,TokenCreator
        /// <summary>
        /// UserLogin method with user detail parameter
        /// </summary>
        /// <param name="userregister"></param>
        /// <returns>return response(token/error)</returns>
        [HttpPost]
        public IActionResult UserLogin(UserRegistration userregister)
        {
           IActionResult response = Unauthorized(); 
            try
            {
                var user = _loginService.Authenticate(userregister);
                if (user != null)
                {
                    var tokenresult = _loginService.TokenCreator(user);
                    response= Ok(new { token = tokenresult });
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        
            return response;
        }

        /// Get: GetUserdata
        /// <summary>
        /// Getting the User Data  
        /// </summary>
        /// <returns>user data</returns>
        [Authorize(Roles ="admin")]
        [HttpGet]
        public IActionResult GetAdmindata()
        {
            try
            {
                var result = _loginService.Getuserdata();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// Get: GetUserdata
        /// <summary>
        /// Getting the User Data  
        /// </summary>
        /// <returns>user data</returns>
        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult Getuserdata()
        {
            try
            {
                var result = _loginService.Getuserdata();
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}