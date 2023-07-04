using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class CoursesController : Controller
    {
        IRepository<Course> _repo;

        public CoursesController(IRepository<Course> repo)
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
