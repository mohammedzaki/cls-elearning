using ELearningApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ELearningApp.Controllers
{
    public class CoursesController : Controller
    {
        [HttpGet("List")]
        public IActionResult IndexList()
        {
            var courseList = new List<Course>();

            courseList.Add(new Course 
            {
                Id = 1,
                Name = "Test",
                Description = "Test",   
                ImgURL = "/images/speakers/melissa-kerr.jpg"
            });
            courseList.Add(new Course
            {
                Id = 2,
                Name = "Test 2",
                Description = "Test 2",
                ImgURL = "/images/speakers/melissa-kerr.jpg"
            });
            courseList.Add(new Course
            {
                Id = 3,
                Name = "Test 3",
                Description = "Test 3",
                ImgURL = "/images/speakers/melissa-kerr.jpg"
            });
            courseList.Add(new Course
            {
                Id = 4,
                Name = "Test 4",
                Description = "Test 4",
                ImgURL = "/images/speakers/melissa-kerr.jpg"
            });

            return View("Index", courseList);
        }

    }
}
