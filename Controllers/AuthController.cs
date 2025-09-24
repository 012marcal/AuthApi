using AuthAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpPost]
        public async Task<ActionResult> Register(UsuarioCriacaoDto user)
        {
            return Ok();
        }
    }
}
