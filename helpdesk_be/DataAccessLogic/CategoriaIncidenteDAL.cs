using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class CategoriaIncidenteDAL
    {
        public IList<CategoriaIncidenteDTO> CategoriaIncidenteLeer(int? id)
        {
            IList<CategoriaIncidenteDTO> CategoriaIncidentes = new List<CategoriaIncidenteDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_INCIDENTE]"
                                + "@OPCION_PROCESO = 1"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        CategoriaIncidenteDTO CategoriaIncidente = new CategoriaIncidenteDTO();
                        CategoriaIncidente.Id = reader.GetInt32(0);
                        CategoriaIncidente.Nombre = reader.GetString(1);
                        CategoriaIncidente.Descripcion = reader.GetString(2);
                        CategoriaIncidente.FechaRegistro = reader.GetDateTime(3);
                        CategoriaIncidente.IdUsuario = reader.GetInt32(4);
                        CategoriaIncidente.FechaActualizacion = reader.GetDateTime(5);

                        CategoriaIncidentes.Add(CategoriaIncidente);

                    }

                con.desconectar();

            }
            catch (Exception e)
            {
                throw e;
            }
            return CategoriaIncidentes;
        }

        public Boolean CategoriaIncidenteCrear(CategoriaIncidenteDTO CategoriaIncidente)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_INCIDENTE]"
                                + "@OPCION_PROCESO = 2"
                                + $",@ID = {CategoriaIncidente.Id}"
                                + $",@NOMBRE = '{CategoriaIncidente.Nombre}'"
                                + $",@DESCRIPCION = '{CategoriaIncidente.Descripcion}'"
                                + $",@FECHA_REGISTRO = '{conversionFechas.ConversionDeFechas(CategoriaIncidente.FechaRegistro)}'"
                                + $",@ID_USUARIO = {CategoriaIncidente.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(CategoriaIncidente.FechaActualizacion)}'";


                SqlCommand command = new SqlCommand(sql, con.conectar());
                command.ExecuteReader();
                con.desconectar();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public Boolean CategoriaIncidenteActualizar(CategoriaIncidenteDTO CategoriaIncidente)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_INCIDENTE]"
                                + "@OPCION_PROCESO = 3"
                                + $",@ID = {CategoriaIncidente.Id}"
                                + $",@NOMBRE = '{CategoriaIncidente.Nombre}'"
                                + $",@DESCRIPCION = '{CategoriaIncidente.Descripcion}'"
                                + $",@ID_USUARIO = {CategoriaIncidente.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(CategoriaIncidente.FechaActualizacion)}'";

                SqlCommand command = new SqlCommand(sql, con.conectar());
                command.ExecuteReader();
                con.desconectar();
            }

            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public Boolean CategoriaIncidenteBorrar(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_INCIDENTE]"
                                + "@OPCION_PROCESO = 4"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                command.ExecuteReader();
                con.desconectar();
            }


            catch (Exception e)
            {
                return false;
            }
            return true;
        }

    }
}