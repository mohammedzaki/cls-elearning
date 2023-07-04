using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ELearningApp.Data.Entities
{
    public class Course : BaseEntity
	{
		[Required]
        public string Title { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string ShortDescription { get; set; }

        [Required]
        public decimal Price { get; set; }


        [NotMapped]
        public string PriceStr { get; set; }

        [NotMapped]
		public string ImgURL { get; set; }

        public virtual ICollection<Lesson> Lessons { get; set; }
    }
}
