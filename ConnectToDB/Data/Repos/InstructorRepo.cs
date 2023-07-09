using ConnectToDB.Models;

namespace ConnectToDB.Data.Repos
{
    public class InstructorRepo : IRepo<Instructor>
    {
        ApplicationDbContext _dbContext;

        public InstructorRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public Instructor Save(Instructor course) 
        {
            _dbContext.Add(course);
            _dbContext.SaveChanges();
            return course;
        }

    }
}
