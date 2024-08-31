using helpdesk_be.Models;
using helpdesk_be.BussinesLogic;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using helpdesk_be.Util;
using Microsoft.Data.SqlClient;

namespace helpdesk_be.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class LoginController: Controller
    {

        [HttpGet]
        public IActionResult loginAutenticacion(string correo,string clave)
        {
            try
            {
                LoginBL loginBL = new LoginBL();
                IList<LoginDTO> usuarioExistente = loginBL.loginAutenticacion(correo, clave);
                if (usuarioExistente.Count()>=1)
                {
                    return Ok(usuarioExistente[0]);
                }
                else
                {
                    return Unauthorized("Correo o Contraseña Invalidos");
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
