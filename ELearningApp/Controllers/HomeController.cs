using ELearningApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }
    }
}
