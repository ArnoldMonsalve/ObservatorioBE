using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace helpdesk_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaProductoController : Controller
    {

        [HttpGet]
        public IList<CategoriaProductoDTO> CategoriaProductoLeer(int? id)
        {
            CategoriaProductoBL CategoriaProductoBL = new CategoriaProductoBL();
            IList<CategoriaProductoDTO> CategoriaProductos = CategoriaProductoBL.CategoriaProductoLeer(id);
            return CategoriaProductos;
        }

        [HttpPost]
        public HttpResponseMessage CategoriaProductoCrear(CategoriaProductoDTO CategoriaProducto)
        {
            CategoriaProductoBL CategoriaProductoBL = new CategoriaProductoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaProductoBL.CategoriaProductoCrear(CategoriaProducto);
                if (exitoso)
                {
                    res = new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception e)
            {
                res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return res;

        }

        [HttpPut]
        public HttpResponseMessage CategoriaProductoActualizar(CategoriaProductoDTO CategoriaProducto)
        {
            CategoriaProductoBL CategoriaProductoBL = new CategoriaProductoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaProductoBL.CategoriaProductoActualizar(CategoriaProducto);
                if (exitoso)
                {
                    res = new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception e)
            {
                res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return res;

        }

        [HttpDelete]
        public HttpResponseMessage CategoriaProductoBorrar(int id)
        {
            CategoriaProductoBL CategoriaProductoBL = new CategoriaProductoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaProductoBL.CategoriaProductoBorrar(id);
                if (exitoso)
                {
                    res = new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }
            }
            catch (Exception e)
            {
                res = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            return res;

        }

    }
}
