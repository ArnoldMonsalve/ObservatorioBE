using helpdesk_be.Util;
using Microsoft.Data.SqlClient;
using helpdesk_be.Models;

namespace helpdesk_be.DataAccessLogic
{
    public class GraficasDAL
    {
        //Leer GraficasDTO        
        public IList<GraficosDTO> graficaLeer(int Opcion)
        {
            IList<GraficosDTO> graficas = new List<GraficosDTO>();
            try
            {
                Conexion con = new Conexion();

                string sql = $"EXEC SP_GRAFICAS @OPCION_PROCESO={Opcion};";

                SqlCommand command = new SqlCommand(sql, con.conectar());

                using (SqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        GraficosDTO grafica = new GraficosDTO();

                        grafica.Encabezado = reader.GetString(0);
                        grafica.Cantidad = reader.GetInt32(1);

                        graficas.Add(grafica);
                    }

                con.desconectar();

            }

            catch (SqlException ex)
            {
                throw ex;
            }
            return graficas;

        }
    }
}

