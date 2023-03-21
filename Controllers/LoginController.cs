using AprendendoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AprendendoMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "Email enviado";
            return View("Index", user);
        }
    }
}
