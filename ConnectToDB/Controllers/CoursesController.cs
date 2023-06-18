using ConnectToDB.Data;
using ConnectToDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectToDB.Controllers
{
    public class CoursesController : Controller
    {
		ApplicationDbContext _dbContext;

        public CoursesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            var courseList = _dbContext.Courses.ToList();

            return View(courseList);
        }


        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Course newCourseData) 
        {
            if (ModelState.IsValid)
            {
                // Sava data to db
                _dbContext.Courses.Add(newCourseData);

                newCourseData.Lessons.Add(new Lesson
                {
                    Name = "Test",
                    Title = "RTTR"
                });
                newCourseData.Lessons.Add(new Lesson
                {
                    Name = "Test 2",
                    Title = "RTTR"
                });
                newCourseData.Lessons.Add(new Lesson
                {
                    Name = "Test 3",
                    Title = "RTTR"
                });
                newCourseData.Lessons.Add(new Lesson
                {
                    Name = "Test 4",
                    Title = "RTTR"
                });

                _dbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else 
            {
                return View();
            }
        }
    }
}
