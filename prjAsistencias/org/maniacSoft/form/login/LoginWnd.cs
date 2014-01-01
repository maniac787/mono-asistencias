using System;
using Gtk;
using org.maniacSoft.attendance.commons.dataAccess;
using System.Collections.Generic;
using org.maniacSoft.attendance.dto;

namespace org.maniacSoft.form.login
{
	/// <summary>
	/// Login window.
	/// Formulario para el login del usuario
	/// </summary>
	public partial class LoginWnd : Gtk.Window
	{
		public LoginWnd () :  base(Gtk.WindowType.Toplevel) {
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnBtnLoginClicked (object sender, EventArgs e)
		{
			System.Console.WriteLine("Iniciando el login");

			try{
				NHibernateBase NHB = new NHibernateBase();
				NHB.Initialize("prjAsistenciasCliente");
				System.Console.WriteLine("NHibernate.GuitarStore assembly initialized.");
				System.Console.ReadLine();

				List<UserDto> list = (List<UserDto>)NHB.ExecuteICriteria<UserDto>();
				
				foreach (UserDto userDto in list)
				{
					System.Console.WriteLine("*****\nuserId..: {0}\tuserName...: {1}\n", userDto.userId, userDto.userName);
				}
				System.Console.WriteLine("Fin");
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

