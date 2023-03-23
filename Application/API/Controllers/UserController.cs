using Common;
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
        /// <param name="user">Username e Senha do usuário</param>
        /// <returns>OK se estiver OK</returns>
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if(user.Password == "123")
            { return Ok(new { response = "OK" }); }
            else
            { return Ok(new { response = "ERROR" }); }
        }
    }
}
