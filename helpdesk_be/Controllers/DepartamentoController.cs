using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;


namespace helpdesk_be.Controllers
{
     
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : Controller
    {
        [HttpGet]
        public IList<DepartamentoDTO> DepartamentoLeer(int? id)
        {
            DepartamentoBL departamentoBL = new DepartamentoBL();
            IList<DepartamentoDTO> departamentos = departamentoBL.DepartamentoLeer();
            return departamentos;
        }

    }
}
