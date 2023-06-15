using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectToDB.Models
{
    public class Course
    {
		[Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

		public string Author { get; set; }

		public string Contributor { get; set; }

		public int Price { get; set; }

		public string Duration { get; set; }

		public string Img { get; set; } = "https://d2o9wnd5wywfpj.cloudfront.net/covers/32/s_banner/portfolio-08-large.jpg?1621306513";
    }
}
