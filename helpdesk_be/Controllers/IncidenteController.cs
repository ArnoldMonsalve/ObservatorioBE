using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace helpdesk_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncidenteController : Controller
    {

        [HttpGet]
        public IList<IncidenteDTO> IncidenteLeer(int? id)
        {
            IncidenteBL IncidenteBL = new IncidenteBL();
            IList<IncidenteDTO> Incidentes = IncidenteBL.IncidenteLeer(id);
            return Incidentes;
        }

        [HttpPost]
        public HttpResponseMessage IncidenteCrear(IncidenteDTO Incidente)
        {
            IncidenteBL IncidenteBL = new IncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = IncidenteBL.IncidenteCrear(Incidente);
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
        public HttpResponseMessage IncidenteActualizar(IncidenteDTO Incidente)
        {
            IncidenteBL IncidenteBL = new IncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = IncidenteBL.IncidenteActualizar(Incidente);
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
        public HttpResponseMessage IncidenteBorrar(int id)
        {
            IncidenteBL IncidenteBL = new IncidenteBL();
            HttpResponseMessage res;
            try
            {
                bool exitoso = IncidenteBL.IncidenteBorrar(id);
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
