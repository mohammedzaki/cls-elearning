using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConnectToDB.Models
{
    public class Instructor
    {
		[Key]
        public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Title { get; set; }

		[AllowNull]
		public string? Description { get; set; }

        [AllowNull]
		public string? Author { get; set; }

		[AllowNull]
		public string? Contributor { get; set; }

		[Required]
		public int Price { get; set; }

		[AllowNull]
		public string? Duration { get; set; }

		[AllowNull]
		public string? Img { get; set; } = "https://d2o9wnd5wywfpj.cloudfront.net/covers/32/s_banner/portfolio-08-large.jpg?1621306513";

        public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    }
}
