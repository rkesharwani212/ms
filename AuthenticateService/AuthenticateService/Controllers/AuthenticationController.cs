using AuthenticateService.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IPublishEndpoint publishEndpoint;
        public AuthenticationController(IPublishEndpoint publishEndpoint)
        {
            this.publishEndpoint = publishEndpoint;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            await publishEndpoint.Publish<LoginDto>(loginDto);
            return Ok();
        }
    }
}
