using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class ProductosBL
    {
        public ProductosBL()
        {

        }

        public IList<ProductosDTO> ProductosLeer(int? id)
        {
            ProductosDAL ProductosDAL = new ProductosDAL();
            IList<ProductosDTO> Productoss = ProductosDAL.ProductosLeer(id);
            return Productoss;
        }

        public bool ProductosCrear(ProductosDTO Productos)
        {
            ProductosDAL ProductosDAL = new ProductosDAL();
            DateTime fechaActual = DateTime.Now; //Consigue la fecha-hora actual
            Productos.FechaRegistro = fechaActual;
            Productos.FechaActualizacion = fechaActual;
            bool exitoso = ProductosDAL.ProductosCrear(Productos);
            return exitoso;
        }

        public bool ProductosActualizar(ProductosDTO Productos)
        {
            ProductosDAL ProductosDAL = new ProductosDAL();
            Productos.FechaActualizacion = DateTime.Now;
            bool exitoso = ProductosDAL.ProductosActualizar(Productos);
            return exitoso;
        }

        public bool ProductosBorrar(int id)
        {
            ProductosDAL ProductosDAL = new ProductosDAL();
            bool exitoso = ProductosDAL.ProductosBorrar(id);
            return exitoso;
        }
    }
}
