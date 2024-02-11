using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterAuthDto authDto)
        {
            _authService.Register(authDto);
            return Ok("Kullanıcı kaydı başarıyla tamamlandı.");
        }
        [HttpPost("login")]
        public IActionResult Login(LoginAuthDto authDto)
        {
            var result = _authService.Login(authDto);
            return Ok(result);
        }

    }
}
