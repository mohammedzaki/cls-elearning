using ELearningApp.Areas.Admin.Models.Courses;
using ELearningApp.Data;
using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Areas.Admin.Contollers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        ApplicationDbContext _db;

        public CoursesController(ApplicationDbContext context)
        {
            _db = context;
        }

        public IActionResult Index() 
        {
            var allCourses = _db.Courses.ToList();
            return View(allCourses);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Create model)
        {
            // save course model to db 

            var newCourse = new Data.Entities.Course();

            newCourse.Title = model.Title;
            newCourse.ShortDescription = model.ShortDescription;
            newCourse.Description = "Test Save";

			_db.Courses.Add(newCourse);

            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}
