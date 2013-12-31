using System;

namespace org.maniacSoft.attendance.dto

{
	/// <summary>
	/// Clase que permite relacionar la cuenta del usuario.
	/// </summary>
	public class UserDto
	{
		public int userId { get; set; }
		public string userName { get; set; }
		public string userPassword { get; set; }

		public UserDto ()
		{
		}
	}
}

