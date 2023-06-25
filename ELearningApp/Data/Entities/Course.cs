using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ELearningApp.Data.Entities
{
    public class Course : BaseEntity
    {
        [AllowNull]
        public string? Title { get; set; }

		[AllowNull]
		public string? Description { get; set; }

		[AllowNull]
		public string? ShortDescription { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
