using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class IncidenteDAL
    {
        public IList<IncidenteDTO> IncidenteLeer(int? id)
        {
            IList<IncidenteDTO> Incidentes = new List<IncidenteDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_INCIDENTE "
                                + "@OPCION_PROCESO = 1"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        IncidenteDTO Incidente = new IncidenteDTO();
                        Incidente.Id = reader.GetInt32(0);
                        Incidente.IdCategoria = reader.GetInt32(1);
                        Incidente.Fecha = reader.GetDateTime(2);
                        Incidente.Descripcion = reader.GetString(3);
                        Incidente.IdImpacto = reader.GetInt32(4);
                        Incidente.IdProducto = reader.GetInt32(5);
                        Incidente.MedidasTomadas = reader.GetString(6);
                        Incidente.IdDepartamento = reader.GetInt32(7);
                        Incidente.IdMunicipio = reader.GetInt32(8);
                        Incidente.IdUsuario = reader.GetInt32(9);
                        Incidente.FechaActualizacion = reader.GetDateTime(10);
                        Incidentes.Add(Incidente);

                    }

                con.desconectar();

            }
            catch (Exception e)
            {
                throw e;
            }
            return Incidentes;
        }

        public Boolean IncidenteCrear(IncidenteDTO Incidente)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_INCIDENTE "
                            + "@OPCION_PROCESO = 2 "
                            + $",@ID = {Incidente.Id}"
                            + $",@ID_CATEGORIA = {Incidente.IdCategoria}"
                            + $",@FECHA = '{conversionFechas.ConversionDeFechas(Incidente.Fecha)}'"
                            + $",@DESCRIPCION = '{Incidente.Descripcion}'"
                            + $",@ID_IMPACTO = {Incidente.IdImpacto}"
                            + $",@ID_PRODUCTO = {Incidente.IdProducto}"
                            + $",@MEDIDAS_TOMADAS = '{Incidente.MedidasTomadas}'"
                            + $",@ID_DEPARTAMENTO = {Incidente.IdDepartamento}"
                            + $",@ID_MUNICIPIO = {Incidente.IdMunicipio}"
                            + $",@ID_USUARIO = {Incidente.IdUsuario}"
                            + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(Incidente.FechaActualizacion)}'";


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

        public Boolean IncidenteActualizar(IncidenteDTO Incidente)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_INCIDENTE "
                            + "@OPCION_PROCESO = 3"
                            + $",@ID = {Incidente.Id}"
                            + $",@ID_CATEGORIA = {Incidente.IdCategoria}"
                            + $",@FECHA = '{conversionFechas.ConversionDeFechas(Incidente.Fecha)}'"
                            + $",@DESCRIPCION = '{Incidente.Descripcion}'"
                            + $",@ID_IMPACTO = {Incidente.IdImpacto}"
                            + $",@ID_PRODUCTO = {Incidente.IdProducto}"
                            + $",@MEDIDAS_TOMADAS = '{Incidente.MedidasTomadas}'"
                            + $",@ID_DEPARTAMENTO = {Incidente.IdDepartamento}"
                            + $",@ID_MUNICIPIO = {Incidente.IdMunicipio}"
                            + $",@ID_USUARIO = {Incidente.IdUsuario}"
                            + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(Incidente.FechaActualizacion)}'";

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

        public Boolean IncidenteBorrar(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_INCIDENTE "
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