using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class CategoriaProductoDAL
    {
        public IList<CategoriaProductoDTO> CategoriaProductoLeer(int? id)
        {
            IList<CategoriaProductoDTO> CategoriaProductos = new List<CategoriaProductoDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_PRODUCTO]"
                                + "@OPCION_PROCESO = 1"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        CategoriaProductoDTO CategoriaProducto = new CategoriaProductoDTO();
                        CategoriaProducto.Id = reader.GetInt32(0);
                        CategoriaProducto.Nombre = reader.GetString(1);
                        CategoriaProducto.Descripcion = reader.GetString(2);
                        CategoriaProducto.FechaRegistro = reader.GetDateTime(3);
                        CategoriaProducto.IdUsuario = reader.GetInt32(4);
                        CategoriaProducto.FechaActualizacion = reader.GetDateTime(5);

                        CategoriaProductos.Add(CategoriaProducto);

                    }

                con.desconectar();

            }
            catch (Exception e)
            {
                throw e;
            }
            return CategoriaProductos;
        }

        public Boolean CategoriaProductoCrear(CategoriaProductoDTO CategoriaProducto)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_PRODUCTO]"
                                + "@OPCION_PROCESO = 2"
                                + $",@ID = {CategoriaProducto.Id}"
                                + $",@NOMBRE = '{CategoriaProducto.Nombre}'"
                                + $",@DESCRIPCION = '{CategoriaProducto.Descripcion}'"
                                + $",@FECHA_REGISTRO = '{conversionFechas.ConversionDeFechas(CategoriaProducto.FechaRegistro)}'"
                                + $",@ID_USUARIO = {CategoriaProducto.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(CategoriaProducto.FechaActualizacion)}'";


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

        public Boolean CategoriaProductoActualizar(CategoriaProductoDTO CategoriaProducto)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_PRODUCTO]"
                                + "@OPCION_PROCESO = 3"
                                + $",@ID = {CategoriaProducto.Id}"
                                + $",@NOMBRE = '{CategoriaProducto.Nombre}'"
                                + $",@DESCRIPCION = '{CategoriaProducto.Descripcion}'"
                                + $",@ID_USUARIO = {CategoriaProducto.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(CategoriaProducto.FechaActualizacion)}'";

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

        public Boolean CategoriaProductoBorrar(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC [dbo].[SP_CATEGORIA_PRODUCTO]"
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