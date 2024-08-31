using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace helpdesk_be.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class GraficasController : Controller
    {
        [HttpGet]
        public IList<GraficosDTO> GraficasLeer(int Opcion)
        {
            GraficasBL GraficasBL = new GraficasBL();
            IList<GraficosDTO> Graficases = GraficasBL.GraficasLeer(Opcion);
            return Graficases;
        }

    }
}
