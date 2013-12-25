using System;

namespace org.maniacSoft.util.conexion
{
	public class PostgreSqlParameter
	{
		private String host;
		private String port;
		private String user;
		private String password;
		private String dataBase;

		public PostgreSqlParameter ()
		{
		}

		public PostgreSqlParameter (string host, string user, string password, string dataBase)
		{
			this.host = host;
			this.user = user;
			this.password = password;
			this.dataBase = dataBase;
		}

		public string Host {
			get {
				return this.host;
			}
			set {
				host = value;
			}
		}

		public string Port {
			get {
				return this.port;
			}
			set {
				port = value;
			}
		}

		public string User {
			get {
				return this.user;
			}
			set {
				user = value;
			}
		}

		public string Password {
			get {
				return this.password;
			}
			set {
				password = value;
			}
		}

		public string DataBase {
			get {
				return this.dataBase;
			}
			set {
				dataBase = value;
			}
		}

	}
}

