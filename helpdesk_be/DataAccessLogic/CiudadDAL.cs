using helpdesk_be.Util;
using Microsoft.Data.SqlClient;
using helpdesk_be.Models;

namespace helpdesk_be.DataAccessLogic
{
    public class CiudadDAL  
    {
        public IList<CiudadDTO> CiudadLeer(int idDpto)
        {
            try
            {
                IList<CiudadDTO> ciudades = new List<CiudadDTO>();
                Conexion con = new Conexion();
                string sql = $"SELECT * FROM CIUDAD WHERE ID_DEPARTAMENTO={idDpto};";

                SqlCommand command = new SqlCommand(sql, con.conectar());

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        CiudadDTO ciudad = new CiudadDTO();
                        ciudad.Id = reader.GetInt32(0);
                        ciudad.Nombre = reader.GetString(1);
                        ciudad.IdDepartamento = reader.GetInt32(2);
                        //ciudad.FechaRegistro = reader.GetDateTime(3);
                        //try
                        //{
                        //    ciudad.IdUsuario = reader.GetInt32(4) ;// en caso de null se trae un cero
                        //}
                        //catch(Exception e) { ciudad.IdUsuario = 0; }     
                        //ciudad.FechaActualizacion = reader.GetDateTime(5);

                        ciudades.Add(ciudad);

                    }
                con.desconectar();
                return ciudades;
            }

            catch (Exception e)
            {
                return null;
            }
        }
    }
}
