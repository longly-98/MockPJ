namespace MockPJ.Utilities.CustomException
{
	public class UpdateFailException : Exception
	{
		public UpdateFailException() { }

		public UpdateFailException(string message) : base(message) { }

		public UpdateFailException(string message, Exception innerException) : base(message, innerException) { }
	}
}
