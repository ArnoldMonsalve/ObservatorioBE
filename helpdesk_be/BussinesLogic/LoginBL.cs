using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class LoginBL
    {
        public LoginBL()
        {

        }
        public IList<LoginDTO> loginAutenticacion(string correo, string clave)
        {
            LoginDAL loginDAL = new LoginDAL();
            IList<LoginDTO> usuarioExistente = loginDAL.loginAutenticacion(correo,clave);
            return usuarioExistente;
        }

    }
}
