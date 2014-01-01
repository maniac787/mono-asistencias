using System;
using org.maniacSoft.attendance.dto;

namespace org.maniacSoft.attendance.service
{
	/// <summary>
	/// I security service.
	/// </summary>
	public interface ISecurityService
	{
		UserDto findUserAccess(String userName, String userPassword);
	}
}

