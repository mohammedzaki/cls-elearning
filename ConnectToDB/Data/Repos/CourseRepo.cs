using ConnectToDB.Models;

namespace ConnectToDB.Data.Repos
{
    public class CourseRepo : IRepo<Course>
    {
        ApplicationDbContext _dbContext;

        public CourseRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public Course Save(Course course)
        {
            throw new NotImplementedException();
        }

        /*public Course Save(Course course) 
        {
            _dbContext.Add(course);
            _dbContext.SaveChanges();
            return course;
        }*/

    }
}
