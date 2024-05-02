using Microsoft.AspNetCore.Mvc;

namespace Mini_Mundo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
