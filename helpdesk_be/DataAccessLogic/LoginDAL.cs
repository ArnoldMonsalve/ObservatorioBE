using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class LoginDAL
    {
        IList<LoginDTO> usuarioExistente = new List<LoginDTO>();
        public IList<LoginDTO> loginAutenticacion(string correo, string clave)
        {
            
            try
            {

                Conexion con = new Conexion();
                string sql = $"EXEC [dbo].[SP_VALIDACION_LOGIN] @CORREO='{correo}', @CLAVE='{clave}';";

                SqlCommand command = new SqlCommand(sql, con.conectar());

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        LoginDTO login = new LoginDTO();

                        login.IdRol = reader.GetInt32(0);
                        login.NombreRol = reader.GetString(1);
                        login.Correo = reader.GetString(2);
                        login.Clave = reader.GetString(3);
                        login.Id=reader.GetInt32(4);
                        login.Nombre = reader.GetString(5);
                        //login.IdEntidad = reader.GetInt32(6);

                        usuarioExistente.Add(login);
                    }
                con.desconectar();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return usuarioExistente;
        }


    }
}
