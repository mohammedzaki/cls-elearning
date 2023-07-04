using ELearningApp.Data;
using ELearningApp.Data.Entities;
using ELearningApp.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Areas.Admin.Contollers
{
    [Area("Admin")]
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
            var course = _repo.FindById(id);
            if (course == null)
            {
                return NotFound();
            }
			return View(course);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(Course model)
		{
            if (ModelState.IsValid)
            {
                await _repo.UpdateAsync(model);
                return RedirectToAction(nameof(Index));
            }
			return View();
		}

	}
}
