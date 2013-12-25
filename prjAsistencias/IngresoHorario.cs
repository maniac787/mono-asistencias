using System;

namespace prjAsistencias {
	public partial class IngresoHorario : Gtk.Window
	{
		private HorarioDia horarioDia;
		public IngresoHorario () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			
			
		}
		
		public void init(DateTime dateTime){
			horarioDia = new HorarioDia(dateTime);
			
			this.fieldSetLabel.Text = "<b>Registro de trabajo al: "+horarioDia.getFechaSeleccionada().ToString("yyyy/MM/dd")+"</b>";
			this.fieldSetLabel.UseMarkup = true;
		}

		protected void OnBtnGuardarClicked (object sender, System.EventArgs e) {

		}
	}
}

