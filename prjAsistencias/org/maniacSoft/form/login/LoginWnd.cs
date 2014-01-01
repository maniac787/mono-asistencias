using System;
using Gtk;
using org.maniacSoft.attendance.commons.dataAccess;
using System.Collections.Generic;
using org.maniacSoft.attendance.dto;
using org.maniacSoft.attendance.service;

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

				ISecurityService securityService = new SecurityService();
				UserDto tmp = securityService.findUserAccess(this.txtUser.Text,this.txtPassword.Text);
				this.eventboxMessage.Visible = false;
				this.Visible = false;

				MainWindow mainWindow = new MainWindow();
				mainWindow.Show ();
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				this.eventboxMessage.Visible = true;
				this.lblErrorLog.LabelProp = "<b>"+message+"</b>";

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

