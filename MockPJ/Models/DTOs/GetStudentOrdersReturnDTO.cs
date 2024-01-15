namespace MockPJ.Models.DTOs
{
	public class GetStudentOrdersReturnDTO
	{
		public int RequestID { get; set; }
		public string? Description { get; set; }
		public string Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime LastModifiedDate { get; set; }
		public GetStudentDetailsReturnDTO StudentDetails { get; set; }
	}
}
