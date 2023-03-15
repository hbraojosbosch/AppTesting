using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [Authorized()]
        [HttpGet("GetUser/{userId}")]
        [ProducesResponseType(typeof(UserLoginResponse), StatusCodes.Status200OK)]
        public IActionResult GetUser([FromRoute] string userId)
        {
            return Ok(userId);
        }
    }
}

