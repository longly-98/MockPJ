namespace MockPJ.Models.DTOs
{
	public class GetHousesRequestDTO
	{
		public string? Keywords { get; set; }
		public int? VillageID { get; set; }
		public int? CampusID { get; set; }
		public string? SortBy { get; set; }
		public string? SortType { get; set; }
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 100;
	}
}
