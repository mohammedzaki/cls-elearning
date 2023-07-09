using System.ComponentModel.DataAnnotations;

namespace ELearningApp.Data.Entities
{
	public abstract class BaseEntity : IEntity
	{
		[Key]
		public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
