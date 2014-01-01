using System;
using org.maniacSoft.attendance.commons.dataAccess;
using org.maniacSoft.attendance.dto;
using NHibernate.Criterion;
using System.Collections.Generic;

namespace org.maniacSoft.attendance.service
{
	public class SecurityService : ISecurityService
	{
		public SecurityService ()
		{
		}

		public org.maniacSoft.attendance.dto.UserDto findUserAccess (String userName, String userPassword)
		{
			NHibernateBase instance = new NHibernateBase();
			instance.Initialize("prjAsistenciasCliente");
			UserDto userDto = null;

			IList<UserDto> result = null;
			try{
				result = instance.ExecuteICriteria<UserDto>(Restrictions.Eq("userName",userName));
				userDto = result[0];
			}catch (Exception e){

			}

			return userDto;
		}
	}
}

