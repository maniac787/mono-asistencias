using System;

namespace prjAsistencias
{
	public partial class CalendarDateSelectWnd : Gtk.Window
	{
		public CalendarDateSelectWnd () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

