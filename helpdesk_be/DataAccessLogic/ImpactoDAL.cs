using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class ImpactoDAL
    {
        public IList<ImpactoDTO> ImpactoLeer(int? id)
        {
            IList<ImpactoDTO> impactos = new List<ImpactoDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_IMPACTO "
                                + "@OPCION_PROCESO = 1"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        ImpactoDTO impacto = new ImpactoDTO();
                        impacto.Id = reader.GetInt32(0);
                        impacto.Nombre = reader.GetString(1);
                        impacto.Descripcion = reader.GetString(2);
                        impacto.FechaRegistro = reader.GetDateTime(3);
                        impacto.IdUsuario = reader.GetInt32(4);
                        impacto.FechaActualizacion = reader.GetDateTime(5);

                        impactos.Add(impacto);

                    }

                con.desconectar();

            }
            catch (Exception e)
            {
                throw e;
            }
            return impactos;
        }

        public Boolean ImpactoCrear(ImpactoDTO impacto)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_IMPACTO "
                                + "@OPCION_PROCESO = 2"
                                + $",@ID = {impacto.Id}"
                                + $",@NOMBRE = '{impacto.Nombre}'"
                                + $",@DESCRIPCION = '{impacto.Descripcion}'"
                                + $",@FECHA_REGISTRO = '{conversionFechas.ConversionDeFechas(impacto.FechaRegistro)}'"
                                + $",@ID_USUARIO = {impacto.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(impacto.FechaActualizacion)}'";


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

        public Boolean ImpactoActualizar(ImpactoDTO impacto)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_IMPACTO "
                                + "@OPCION_PROCESO = 3"
                                + $",@ID = {impacto.Id}"
                                + $",@NOMBRE = '{impacto.Nombre}'"
                                + $",@DESCRIPCION = '{impacto.Descripcion}'"
                                + $",@ID_USUARIO = {impacto.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(impacto.FechaActualizacion)}'";

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

        public Boolean ImpactoBorrar(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_IMPACTO "
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