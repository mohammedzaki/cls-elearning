using ConnectToDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ConnectToDB.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
        }

        public DbSet<Course> Courses { get; set; }

		public DbSet<Lesson> Lessons { get; set; }

	}
}
