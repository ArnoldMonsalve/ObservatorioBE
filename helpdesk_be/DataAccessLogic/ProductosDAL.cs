using helpdesk_be.Models;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.DataAccessLogic
{
    public class ProductosDAL
    {
        public IList<ProductosDTO> ProductosLeer(int? id)
        {
            IList<ProductosDTO> Productoss = new List<ProductosDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_PRODUCTO "
                                + "@OPCION_PROCESO = 1"
                                + $",@ID = {id}";
                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        ProductosDTO Productos = new ProductosDTO();
                        Productos.Id = reader.GetInt32(0);
                        Productos.Nombre = reader.GetString(1);
                        Productos.IdCategoriaProducto = reader.GetInt32(2);
                        Productos.Fabricante = reader.GetString(3);
                        Productos.Descripcion = reader.GetString(4);
                        Productos.FechaRegistro = reader.GetDateTime(5);
                        Productos.IdUsuario = reader.GetInt32(6);
                        Productos.FechaActualizacion = reader.GetDateTime(7);
                        Productoss.Add(Productos);

                    }

                con.desconectar();

            }
            catch (Exception e)
            {
                throw e;
            }
            return Productoss;
        }

        public Boolean ProductosCrear(ProductosDTO Productos)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_PRODUCTO "
                                + "@OPCION_PROCESO = 2"
                                + $",@ID = {Productos.Id}"
                                + $",@NOMBRE = '{Productos.Nombre}'"
                                + $",@ID_CATEGORIA_PRODUCTO = {Productos.IdCategoriaProducto}"
                                + $",@FABRICANTE = '{Productos.Fabricante}'"
                                + $",@DESCRIPCION = '{Productos.Descripcion}'"
                                + $",@FECHA_REGISTRO = '{conversionFechas.ConversionDeFechas(Productos.FechaRegistro)}'"
                                + $",@ID_USUARIO = {Productos.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(Productos.FechaActualizacion)}'";


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

        public Boolean ProductosActualizar(ProductosDTO Productos)
        {
            try
            {
                Conexion con = new Conexion();
                ConversionFechas conversionFechas = new ConversionFechas();
                string sql = $"EXEC SP_PRODUCTO "
                                + "@OPCION_PROCESO = 3"
                                + $",@ID = {Productos.Id}"
                                + $",@NOMBRE = '{Productos.Nombre}'"
                                + $",@ID_CATEGORIA_PRODUCTO = {Productos.IdCategoriaProducto}"
                                + $",@FABRICANTE = '{Productos.Fabricante}'"
                                + $",@DESCRIPCION = '{Productos.Descripcion}'"
                                + $",@FECHA_REGISTRO = '{conversionFechas.ConversionDeFechas(Productos.FechaRegistro)}'"
                                + $",@ID_USUARIO = {Productos.IdUsuario}"
                                + $",@FECHA_ACTUALIZACION = '{conversionFechas.ConversionDeFechas(Productos.FechaActualizacion)}'";

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

        public Boolean ProductosBorrar(int id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_PRODUCTO "
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