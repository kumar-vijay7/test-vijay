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
    public class LoginController : ControllerBase
    {
        readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginrepository)
        {
            _loginRepository = loginrepository;
        }

        [HttpPost]
        public async Task<ActionResult> Login(TblLogin user )
        {
            var response =await  _loginRepository.Login(user);
            if (response)
            {
                return Ok();
            }
            else
            {
                return StatusCode(401);
            }
        }
    }
}