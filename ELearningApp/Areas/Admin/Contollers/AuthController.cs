using Microsoft.AspNetCore.Mvc;
using ELearningApp.Config;

namespace ELearningApp.Areas.Admin.Contollers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login()
        {
            HttpContext.Session.SetString(SessionKeys.SessionUserNameKey, "Test Test");
            HttpContext.Session.SetString(SessionKeys.SessionUserIdKey, "123");
            return RedirectToAction("Index", "Home");
        }
    }
}
