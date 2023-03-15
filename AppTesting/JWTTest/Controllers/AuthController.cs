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
        protected readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("GetToken")]
        [ProducesResponseType(typeof(UserLoginResponse), StatusCodes.Status200OK)]
        public IActionResult GetToken([FromBody] UserLoginRequest userCredentils)
        {
            return Ok(_authenticationService.Authenticate(userCredentils));
        }
	}
}

