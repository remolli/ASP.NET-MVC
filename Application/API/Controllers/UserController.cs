using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autentifica o usuário
        /// </summary>
        /// <param name="username">Username do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <returns>OK</returns>
        [HttpGet]
        public IActionResult Login(string username, string password)
        {
            return Ok( new { response = "Login Success" });
        }
    }
}
