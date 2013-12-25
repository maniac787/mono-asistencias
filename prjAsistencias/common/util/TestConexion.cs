using System;

using System.Data;
using Npgsql;
 
namespace prjAsistencias {
  public class TestConexion {
    public TestConexion () {
    }
    
    
    public void iniciar() {
       string connectionString =
          "Server=127.0.0.1;" +
          "Database=smx;" +
          "User ID=postgres;" +
          "Password=admin;";
       IDbConnection dbcon;
       dbcon = new NpgsqlConnection(connectionString);
       dbcon.Open();
       IDbCommand dbcmd = dbcon.CreateCommand();
       // requires a table to be created named employee
       // with columns firstname and lastname
       // such as,
       //        CREATE TABLE employee (
       //           firstname varchar(32),
       //           lastname varchar(32));
		string sql = "SELECT usr_id, usr_name FROM smx_user";


       dbcmd.CommandText = sql;

			IDataReader reader = null;
		try{
			reader = dbcmd.ExecuteReader();
		}catch(Exception e){
			System.Console.WriteLine(e);
		}
       
       while(reader.Read()) {
				int FirstName = reader.GetInt32(reader.GetOrdinal("usr_id"));
				string LastName = reader.GetString(reader.GetOrdinal("usr_name"));
            Console.WriteLine("Name: " + FirstName + " " + LastName);
       }
       // clean up
       reader.Close();
       reader = null;
       dbcmd.Dispose();
       dbcmd = null;
       dbcon.Close();
       dbcon = null;
    }
  }
}

