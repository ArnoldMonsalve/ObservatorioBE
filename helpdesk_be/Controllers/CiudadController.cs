using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace helpdesk_be.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CiudadController: Controller
    {
        [HttpGet]
        public IList<CiudadDTO> CiudadLeer(int idDpto)
        {
            CiudadBL ciudadBL = new CiudadBL();
            IList<CiudadDTO> ciudades = ciudadBL.CiudadLeer(1);
            return ciudades;
        }

    }
}
