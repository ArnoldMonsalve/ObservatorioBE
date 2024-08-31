using System;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Configuration;



namespace helpdesk_be.Util
{
    public class Conexion
    {
        SqlConnection con;
 

        public Conexion()
        { /*
            var appSettings = ConfigurationManager;
            string result = appSettings[Key0] ?? "Not Found";
            Console.WriteLine(result);*/

            //var configuration = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile($"appsettings.json");

            //var config = configuration.Build();
            //var connectionString = config["ConnectionString"];

            Parametros parametros = new Parametros();


            con = new SqlConnection(parametros.LeerPropiedadesConfiguracion("ConnectionString"));
            //con = new SqlConnection("Server=181.50.121.22\\TRANSFORDEV;Initial Catalog=T_HELPDESK; Integrated Security=false;User id=TRANSFOR;Password=uestrasu5Le;Trust Server Certificate=true;Encrypt=true;User Instance=false");
        }

        public SqlConnection conectar()
        {
            try
            {
                con.Open();
                return con;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool desconectar()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
