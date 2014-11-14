using System;

namespace FixPonto
{
	public class ParseException : ApplicationException
	{
		public ParseException(string message) : base(message)
		{
		}
	}
}

