namespace ELearningApp.Data.Entities
{
	public class Lesson : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int CourseId { get; set; }

	}
}
