using AuthAPI.DTOs;
using AuthAPI.Services.AuthService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
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

        [HttpPost]
        public async Task<ActionResult> Register(UsuarioCriacaoDto user)
        {

            var registro = await _authService.Registrar(user);
            return Ok(registro);
        }
    }
}
