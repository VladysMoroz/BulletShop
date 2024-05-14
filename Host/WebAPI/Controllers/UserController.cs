using ApplicationServices.Services;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase   
       {
         private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("Register", Name = "Register")]
        public async Task<IResult> Register([FromBody]RegisterUserRequest request)
        {
            await _userService.Register(request.UserName, request.Email, request.Password);

            return Results.Ok();
        }

        [HttpPost("Login", Name = "Login")]
        public async Task<IResult> Login([FromBody] LoginUserRequest request)
        {
            var token = await _userService.Login(request.Email, request.Password);

            _httpContextAccessor.HttpContext.Response.Cookies.Append("tasty-cookies", token);


            return Results.Ok();
        }
    }
}
