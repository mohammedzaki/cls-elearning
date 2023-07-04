using ELearningApp.Data.Entities;
using Microsoft.CodeAnalysis.Classification;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ELearningApp.Data.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private readonly ApplicationDbContext _context;

        public CourseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Course> FindById(int id)
        {
            var course = await _context.Courses.Where(e => e.Id == id).FirstOrDefaultAsync();
            return course ?? null;
        }

        public async Task<List<Course>> GetAll()
        {
            var coursesList = await _context.Courses.ToListAsync();
            foreach (var item in coursesList)
            {
                item.ImgURL = "https://learn.microsoft.com/dotnet/media/dotnet-logo.png";
                item.PriceStr = $"{item.Price} EGP";
            }
            return coursesList;
        }

        public async Task SaveAsync(Course course) 
        {
            _context.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course course)
        {
            _context.Update(course);
            await _context.SaveChangesAsync();
        }
    }
}
