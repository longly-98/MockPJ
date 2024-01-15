namespace MockPJ.Models.DTOs
{
	public class GetStudentOrdersRequestDTO
	{
		public string? Keywords { get; set; }
		public string? SortBy { get; set; }
		public string? SortType { get; set; }
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 100;
	}
}
