using Microsoft.EntityFrameworkCore;

namespace ELearningApp.Data.Entities
{
	[PrimaryKey(nameof(CourseId), nameof(StudentId))]
	public class StudentCourse
	{
		public int CourseId { get; set; }

		public int StudentId { get; set; }

		public virtual Course Course { get; set; }

		public virtual Student Student { get; set; }
	}
}
