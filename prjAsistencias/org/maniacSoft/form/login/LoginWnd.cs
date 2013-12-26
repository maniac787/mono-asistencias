using System;
using Gtk;

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
		}

	}
}

