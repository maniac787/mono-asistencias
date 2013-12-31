using System;
using Gtk;
using prjAsistencias;
using org.maniacSoft.util.conexion;
using org.maniacSoft.test;


public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnCalendarMesDaySelected (object sender, System.EventArgs e)
	{
		String msg = "Hola";
		
		/*
		MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, msg);
        md.Run ();
        md.Destroy(); 
		*/


		PostgreSqlConexion.Instance.iniciar();
		ListStore store = new ListStore(typeof (string));
		
		
		
		store.AppendValues ("zxdczxsdf");   
		
		this.comboboxentry2.Model = store;
		
		IngresoHorario ingresoHorario = new IngresoHorario();
		ingresoHorario.init(((Calendar)sender).Date);
		ingresoHorario.Show();
		
		TestConexion testConexion = new TestConexion();
		testConexion.iniciar();
		/*
		HorarioDiario horarioDiario = new HorarioDiario();
		horarioDiario.setDateTime(((Calendar)sender).Date);
		horarioDiario.Run();
		horarioDiario.Destroy(); 
		*/
		
	}
}
