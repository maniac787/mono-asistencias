using System;
using Gtk;
using org.maniacSoft.form.login;
namespace prjAsistencias
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			LoginWnd win = new LoginWnd ();
			win.Show ();
			Application.Run ();
		}
	}
}
