
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Calendar calendarMes;
	private global::Gtk.ComboBoxEntry comboboxentry2;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.calendarMes = new global::Gtk.Calendar ();
		this.calendarMes.CanFocus = true;
		this.calendarMes.Name = "calendarMes";
		this.calendarMes.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
		this.fixed1.Add (this.calendarMes);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.calendarMes]));
		w1.X = 220;
		w1.Y = 42;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.comboboxentry2 = global::Gtk.ComboBoxEntry.NewText ();
		this.comboboxentry2.Name = "comboboxentry2";
		this.fixed1.Add (this.comboboxentry2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.comboboxentry2]));
		w2.X = 19;
		w2.Y = 43;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 476;
		this.DefaultHeight = 304;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.calendarMes.DaySelected += new global::System.EventHandler (this.OnCalendarMesDaySelected);
	}
}