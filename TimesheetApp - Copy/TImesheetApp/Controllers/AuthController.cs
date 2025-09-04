using Microsoft.AspNetCore.Mvc;
using TimesheetApp.Models;
using TimesheetApp.Services;
using TImesheetApp.Models;
using TImesheetApp.Services;

namespace TImesheetApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginEmployee)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var response = _authService.Login(loginEmployee);
                if (response != null)
                {
                    return Ok(new { response });
                }
                return Unauthorized(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Failed to login employee",
                    details = ex.Message
                });
            }
        }

    }
}
