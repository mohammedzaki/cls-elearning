using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConnectToDB.Models
{
	public class Lesson
	{
		[Key]
		public int Id { get; set; }

		[AllowNull]
		public string? Name { get; set; }

		[AllowNull]
		public string? Title { get; set; }
		
		public int CourseId { get; set; }
	}
}
