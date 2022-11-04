using BubberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;
using BubberDinner.Application.Services.Authentication;

namespace BubberDinner.Api
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authencationService;

        public AuthenticationController(IAuthenticationService authencationService)
        {
            this._authencationService = authencationService;
        }
        
        [HttpPost("register")]
        public ActionResult Register(RegisterRequest request)
        {
            return Ok(_authencationService.Register(
                request.FirstName, 
                request.LastName, 
                request.Email, 
                request.Password
                )
            );
        }

        [HttpPost("login")]
        public ActionResult Login(LoginRequest request)
        {
            return Ok(_authencationService.Login(request.Email, request.Password));
        }
    }
}