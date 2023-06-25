using ELearningApp.Data;
using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class CoursesController : Controller
    {
		ApplicationDbContext _db;

		public CoursesController(ApplicationDbContext context)
		{
			_db = context;
		}

		public IActionResult Index()
        {
            return View();
        }
    }
}
