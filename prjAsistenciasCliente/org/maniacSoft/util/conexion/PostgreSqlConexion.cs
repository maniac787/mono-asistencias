using System;

namespace org.maniacSoft.util.conexion {
	/// <summary>
	///  Permite la conexion con el motor de postgresql
	/// </summary>
	public class PostgreSqlConexion {
		static readonly PostgreSqlConexion instance = new PostgreSqlConexion();

		public static PostgreSqlConexion Instance {
			get {
				return instance;
			}
		}

		private PostgreSqlConexion () {
		}

		public void iniciar() {
			PostgreSqlParameter postgreSqlParameter = new PostgreSqlParameter("127.0.0.1","postgres", "admin", "smx");
		}

		public override string ToString ()
		{
			return string.Format ("[PostgreSqlConexion: ]");
		}
	}
}

