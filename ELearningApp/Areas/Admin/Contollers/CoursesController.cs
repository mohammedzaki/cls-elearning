using ELearningApp.Data;
using ELearningApp.Data.Entities;
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
        public IActionResult Create(Course model)
        {
            // save course model to db 
            if (ModelState.IsValid)
            {
                _db.Courses.Add(model);

                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View();
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
            var course = _db.Courses.Where(e => e.Id == id).FirstOrDefault();
            if (course == null)
            {
                return NotFound();
            }
			return View(course);
		}

		[HttpPost]
		public IActionResult Edit(Course model)
		{
            if (ModelState.IsValid)
            {
                _db.Update(model);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
			return View();
		}

	}
}
