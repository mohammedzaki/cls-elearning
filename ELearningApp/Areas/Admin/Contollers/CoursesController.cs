using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Areas.Admin.Contollers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        CourseRepository _repo;
        ApplicationDbContext _db;

        public CoursesController(CourseRepository repo, ApplicationDbContext db)
        {
            _repo = repo;
            _db = db;
        }

        public async Task<IActionResult> Index() 
        {
            var coursesList = await _repo.GetAll();
            return View(coursesList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course model)
        {
            // save course model to db 
            if (ModelState.IsValid)
            {
                await _repo.SaveAsync(model);
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
