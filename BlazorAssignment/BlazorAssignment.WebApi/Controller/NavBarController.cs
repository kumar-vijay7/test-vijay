using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAssignment.WebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorAssignment.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavBarController : ControllerBase
    {
        private readonly INavRepository _navRepository;

        public NavBarController(INavRepository navRepository)
        {
            _navRepository = navRepository;
        }
        /// <summary>
        /// This Method provide all the navbar data
        /// </summary>
        /// <returns>list of navbar</returns>
        [HttpGet]
        public async Task<ActionResult> GetNavBar()
        {
            return Ok(await _navRepository.GetNavDatas());
        }
    }
}