using System.ComponentModel.DataAnnotations;

namespace ELearningApp.Data.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }
    }
}
