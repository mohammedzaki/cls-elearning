using Microsoft.EntityFrameworkCore;

namespace ELearningApp.Data.Entities
{
	[PrimaryKey(nameof(CourseId), nameof(InstructorId))]
	public class InstructorCourse
	{
		public int CourseId { get; set; }

		public int InstructorId { get; set; }

		public virtual Course Course { get; set; }

		public virtual Instructor Instructor { get; set; }


	}
}
