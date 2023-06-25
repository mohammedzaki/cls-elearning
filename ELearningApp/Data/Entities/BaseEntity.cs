﻿using System.ComponentModel.DataAnnotations;

namespace ELearningApp.Data.Entities
{
	public abstract class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
