﻿using System.ComponentModel.DataAnnotations;

namespace MockPJ.Models.DTOs
{
	public class AuthRequest
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; } = null!;
		[Required]
		public string Password { get; set; } = null!;
	}
}
