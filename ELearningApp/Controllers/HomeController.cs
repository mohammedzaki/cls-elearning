using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
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
