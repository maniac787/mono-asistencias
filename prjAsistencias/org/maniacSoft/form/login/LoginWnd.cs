using System;

namespace org.maniacSoft.form.login
{
	public partial class LoginWnd : Gtk.Window
	{
		public LoginWnd () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

