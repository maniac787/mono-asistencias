using System;
using NUnit.Framework;
using org.maniacSoft.attendance.commons.dataAccess;
using org.maniacSoft.attendance.dto;
using System.Collections.Generic;

namespace prjAsistenciasCliente
{
	[TestFixture()]
	public class TestConexion
	{
		[Test()]
		public void TestCase ()
		{
			try{
				NHibernateBase NHB = new NHibernateBase();
				NHB.Initialize("prjAsistenciasCliente");
				System.Console.WriteLine("prjAsistenciasCliente assembly initialized.");
				System.Console.ReadLine();
				List<UserDto> list = (List<UserDto>)NHB.ExecuteICriteria<UserDto>();
				
				foreach (UserDto userDto in list)
				{
					Console.WriteLine("*****\nuserId..: {0}\tuserName...: {1}\n", userDto.userId, userDto.userName);
				}
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				if (ex.InnerException != null)
				{
					message += " - InnerExcepetion: " + ex.InnerException.Message;
				}
				System.Console.WriteLine();
				System.Console.WriteLine("***** ERROR *****");
				System.Console.WriteLine(message);
				System.Console.WriteLine();
				System.Console.ReadLine();
			}
		}
	}
}

