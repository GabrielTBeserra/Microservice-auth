using AUTH_SERVICE_CROSSCUTING.DTO.User;
using AUTH_SERVICE_SERVICE.ApplicationService.Auth.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace AUTH_SERVICE_INTERFACE.Controllers.Auth
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly IAuthApplicationService _authApplicationService;

        public AuthController(IAuthApplicationService authApplicationService)
        {
            _authApplicationService = authApplicationService;
        }

        [SwaggerResponse(statusCode: 200, description: "Login Success", Type = typeof(LoginResponseDto))]
        [SwaggerResponse(statusCode: 400, description: "Internal Server Error", Type = typeof(string))]
        [SwaggerResponse(statusCode: 409, description: "Conflict", Type = typeof(string))]
        [SwaggerResponse(statusCode: 404, description: "User not found", Type = typeof(string))]
        [Produces("application/json")]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto, CancellationToken ctToken) => Ok(await _authApplicationService.Login(dto, ctToken));


        [SwaggerResponse(statusCode: 200, description: "Register Success")]
        [SwaggerResponse(statusCode: 400, description: "Internal Server Error", Type = typeof(string))]
        [SwaggerResponse(statusCode: 409, description: "Conflict", Type = typeof(string))]
        [Produces("application/json")]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto, CancellationToken ctToken)
        {
            await _authApplicationService.Register(dto, ctToken);
            return Ok();
        }

    }
}
