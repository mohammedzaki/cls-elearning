using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
