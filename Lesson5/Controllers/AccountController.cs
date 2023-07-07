using Microsoft.AspNetCore.Mvc;

namespace Lesson5.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
