using Microsoft.AspNetCore.Mvc;

namespace AprendendoMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
