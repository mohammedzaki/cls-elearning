using ConnectToDB.Data;
using ConnectToDB.Data.Repos;
using ConnectToDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConnectToDB.Controllers
{
    public class CoursesController : Controller
    {
        IRepo<Course> _repo;

        public CoursesController(IRepo<Course> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            //var courseList = _dbContext.Courses.ToList();

            return View();
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

                _repo.Save(newCourseData);

                return RedirectToAction(nameof(Index));
            }
            else 
            {
                return View();
            }
        }
    }
}
