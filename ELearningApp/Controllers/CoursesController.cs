using ELearningApp.Data;
using ELearningApp.Data.Repositories;
using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class CoursesController : Controller
    {
        CourseRepository _repo;

        public CoursesController(CourseRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var coursesList = await _repo.GetAll();
            return View(coursesList);
        }
    }
}
