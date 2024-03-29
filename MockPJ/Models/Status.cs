﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MockPJ.Models
{
	public class Status : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StatusID { get; set; }
		public string StatusName { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}
