namespace ELearningApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }    

        public string Description { get; set; } 

        public string ImgURL { get; set; }
        public List<string> CourseName { set;  get; }
    }
}
