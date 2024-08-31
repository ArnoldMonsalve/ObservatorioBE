using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace helpdesk_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : Controller
    {

        [HttpGet]
        public IList<ProductosDTO> ProductosLeer(int? id)
        {
            ProductosBL ProductosBL = new ProductosBL();
            IList<ProductosDTO> Productoss = ProductosBL.ProductosLeer(id);
            return Productoss;
        }

        [HttpPost]
        public HttpResponseMessage ProductosCrear(ProductosDTO Productos)
        {
            ProductosBL ProductosBL = new ProductosBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = ProductosBL.ProductosCrear(Productos);
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
        public HttpResponseMessage ProductosActualizar(ProductosDTO Productos)
        {
            ProductosBL ProductosBL = new ProductosBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = ProductosBL.ProductosActualizar(Productos);
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
        public HttpResponseMessage ProductosBorrar(int id)
        {
            ProductosBL ProductosBL = new ProductosBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = ProductosBL.ProductosBorrar(id);
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
