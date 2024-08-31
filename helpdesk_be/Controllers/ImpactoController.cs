using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace helpdesk_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImpactoController : Controller
    {

        [HttpGet]
        public IList<ImpactoDTO> ImpactoLeer(int? id)
        {
            ImpactoBL impactoBL = new ImpactoBL();
            IList<ImpactoDTO> impactos = impactoBL.ImpactoLeer(id);
            return impactos;
        }

        [HttpPost]
        public HttpResponseMessage ImpactoCrear(ImpactoDTO impacto)
        {
            ImpactoBL impactoBL = new ImpactoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = impactoBL.ImpactoCrear(impacto);
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
        public HttpResponseMessage ImpactoActualizar(ImpactoDTO impacto)
        {
            ImpactoBL impactoBL = new ImpactoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = impactoBL.ImpactoActualizar(impacto);
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
        public HttpResponseMessage ImpactoBorrar(int id)
        {
            ImpactoBL impactoBL = new ImpactoBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = impactoBL.ImpactoBorrar(id);
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
