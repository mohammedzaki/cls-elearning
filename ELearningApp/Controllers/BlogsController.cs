using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    [Authorize]
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
