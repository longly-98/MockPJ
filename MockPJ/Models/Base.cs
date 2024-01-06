namespace MockPJ.Models
{
	public class Base
	{
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public DateTime? LastModifiedDate { get; set; }
	}
}
