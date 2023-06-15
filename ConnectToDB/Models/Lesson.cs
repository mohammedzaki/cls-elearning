﻿using System.ComponentModel.DataAnnotations;

namespace ConnectToDB.Models
{
	public class Lesson
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Title { get; set; }
	}
}
