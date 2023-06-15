using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
