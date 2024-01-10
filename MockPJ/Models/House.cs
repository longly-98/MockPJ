using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
namespace MockPJ.Models
{
	public class House : Base
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int HouseID { get; set; }
		public string HouseName { get; set; }
		public string Information { get; set; }
		public int AddressID { get; set; }
		public int? VillageID { get; set; }
		public int? LandLordID { get; set; }
		public int? CampusID { get; set; }
		public float PowerPrice { get; set; }
		public float WaterPrice { get; set; }
		public int? CreatedBy { get; set; }
		public int? LastModifiedBy { get; set; }
		public User Creator { get; set; }
		public User Modifier { get; set; }
		public Campus Campus { get; set; }
		public Village Village { get; set; }
		public Address Address { get; set; }
		public ICollection<Room> Rooms { get; set; }
		public ICollection<Rate> Rates { get; set; }
		public ICollection<HouseImage> HouseImages { get; set; }
		public ICollection<Report> Reports { get; set; }
		public User LandLord { get; set; }
	}
}