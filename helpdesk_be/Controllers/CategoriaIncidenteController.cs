using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace helpdesk_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaIncidenteController : Controller
    {

        [HttpGet]
        public IList<CategoriaIncidenteDTO> CategoriaIncidenteLeer(int? id)
        {
            CategoriaIncidenteBL CategoriaIncidenteBL = new CategoriaIncidenteBL();
            IList<CategoriaIncidenteDTO> CategoriaIncidentes = CategoriaIncidenteBL.CategoriaIncidenteLeer(id);
            return CategoriaIncidentes;
        }

        [HttpPost]
        public HttpResponseMessage CategoriaIncidenteCrear(CategoriaIncidenteDTO CategoriaIncidente)
        {
            CategoriaIncidenteBL CategoriaIncidenteBL = new CategoriaIncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaIncidenteBL.CategoriaIncidenteCrear(CategoriaIncidente);
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
        public HttpResponseMessage CategoriaIncidenteActualizar(CategoriaIncidenteDTO CategoriaIncidente)
        {
            CategoriaIncidenteBL CategoriaIncidenteBL = new CategoriaIncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaIncidenteBL.CategoriaIncidenteActualizar(CategoriaIncidente);
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
        public HttpResponseMessage CategoriaIncidenteBorrar(int id)
        {
            CategoriaIncidenteBL CategoriaIncidenteBL = new CategoriaIncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = CategoriaIncidenteBL.CategoriaIncidenteBorrar(id);
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
