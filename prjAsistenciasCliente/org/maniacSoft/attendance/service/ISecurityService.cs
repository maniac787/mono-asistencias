using System;
using org.maniacSoft.attendance.dto;

namespace org.maniacSoft.attendance.service
{
	public interface ISecurityService
	{
		UserDto findUserAccess(String userName, String userPassword);
	}
}

