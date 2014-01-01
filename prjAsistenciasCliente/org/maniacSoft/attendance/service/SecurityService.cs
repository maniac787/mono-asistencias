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
			Conjunction criterion = new NHibernate.Criterion.Conjunction();
			criterion.Add(Restrictions.Eq("userName",userName));
			criterion.Add(Restrictions.Eq("userPassword",userPassword));
			IList<UserDto> result = null;
			try{
				result = instance.ExecuteICriteria<UserDto>(criterion);
				if(result == null || result.Count == 0){
					throw new Exception("El usuario o clave es incorrecto");
				}
				userDto = result[0];
			}catch (Exception e){
				throw new Exception(e.Message);
			}

			return userDto;
		}
	}
}

