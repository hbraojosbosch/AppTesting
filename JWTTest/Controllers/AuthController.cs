using System;
using System.Collections.Generic;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationExamples.JWTTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
	{

        [HttpPost("GetToken")]
        [ProducesResponseType(typeof(UserCredentialsResponse), StatusCodes.Status200OK)]
        public IActionResult GetToken([FromBody] UserCredentialsRequest userCredentils)
        {
            return null;
        }
	}
}

