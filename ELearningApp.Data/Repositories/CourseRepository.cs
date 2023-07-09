using ELearningApp.Data.Entities;
using Microsoft.CodeAnalysis.Classification;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ELearningApp.Data.Repositories
{
    public class CourseRepository : EntityRepository<Course>
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
            : base(context)
        {
            _context = context;
        }

        public override async Task<List<Course>> GetAll()
        {
            var coursesList = await _context.Courses.ToListAsync();
            foreach (var item in coursesList)
            {
                item.ImgURL = "https://learn.microsoft.com/dotnet/media/dotnet-logo.png";
                item.PriceStr = $"{item.Price} EGP";
            }
            return coursesList;
        }
    }
}
