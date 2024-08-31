using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class CategoriaProductoBL
    {
        public CategoriaProductoBL()
        {

        }

        public IList<CategoriaProductoDTO> CategoriaProductoLeer(int? id)
        {
            CategoriaProductoDAL CategoriaProductoDAL = new CategoriaProductoDAL();
            IList<CategoriaProductoDTO> CategoriaProductos = CategoriaProductoDAL.CategoriaProductoLeer(id);
            return CategoriaProductos;
        }

        public bool CategoriaProductoCrear(CategoriaProductoDTO CategoriaProducto)
        {
            CategoriaProductoDAL CategoriaProductoDAL = new CategoriaProductoDAL();
            DateTime fechaActual = DateTime.Now; //Consigue la fecha-hora actual
            CategoriaProducto.FechaRegistro = fechaActual;
            CategoriaProducto.FechaActualizacion = fechaActual;
            bool exitoso = CategoriaProductoDAL.CategoriaProductoCrear(CategoriaProducto);
            return exitoso;
        }

        public bool CategoriaProductoActualizar(CategoriaProductoDTO CategoriaProducto)
        {
            CategoriaProductoDAL CategoriaProductoDAL = new CategoriaProductoDAL();
            CategoriaProducto.FechaActualizacion = DateTime.Now;
            bool exitoso = CategoriaProductoDAL.CategoriaProductoActualizar(CategoriaProducto);
            return exitoso;
        }

        public bool CategoriaProductoBorrar(int id)
        {
            CategoriaProductoDAL CategoriaProductoDAL = new CategoriaProductoDAL();
            bool exitoso = CategoriaProductoDAL.CategoriaProductoBorrar(id);
            return exitoso;
        }
    }
}
