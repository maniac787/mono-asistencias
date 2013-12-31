using System;

namespace prjAsistencias
{
	public class HorarioDia
	{
		private DateTime fechaSeleccionada;
		private TimeSpan horaEntrada;
		private TimeSpan horaSalida;
		
		public HorarioDia ()
		{
		}
		
		public HorarioDia(DateTime dateTime){
			this.fechaSeleccionada = dateTime;
		}
		
		public DateTime getFechaSeleccionada(){
			return this.fechaSeleccionada;
		}
	}
}

