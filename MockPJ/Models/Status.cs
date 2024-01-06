namespace MockPJ.Models
{
	public class Status : Base
	{
		public int StatusID { get; set; }
		public string StatusName { get; set; }
		public ICollection<Room> Rooms { get; set; }
	}
}
