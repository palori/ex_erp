using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

using erp_api.Models;
using erp_api.Services;
using erp_api.Data.DTO;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authService;

        public AuthenticateController(IAuthenticateService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(AuthenticateRequest model)
        {
            var response = await _authService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            
            return Ok(response);
        }

        // [log in] for the next iteration
    }
}
