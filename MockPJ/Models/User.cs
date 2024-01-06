﻿using System.Security.Cryptography.X509Certificates;

namespace MockPJ.Models
{
	public class User : Base
	{
		public int UserID { get; set; }
		public string FacebookUserID { get; set; }
		public string GoogleUserID { get; set; }
		public string Email {  get; set; }
		public string PassWord { get; set; }
		public string DisplayName { get; set; }
		public bool Active { get; set; }
		public string ProfileImageLink { get; set; }
		public string PhoneNumber { get; set; }
		public string FacebookURL { get; set; }
		public string IdentityCardFrontSideImageLink { get; set; }
		public string IdentityCardBackSideImageLink { get; set; }
		public int AddressID { get; set; }
		public int RoleID { get; set; }
		public int CreatedBy { get; set; }
		public int LastModifiedBy { get; set; }
	}
}