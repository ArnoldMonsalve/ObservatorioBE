using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class CiudadBL
    {

        public CiudadBL()
        {

        }

        public IList<CiudadDTO> CiudadLeer(int idDpto)
        {
            CiudadDAL ciudadDAL = new CiudadDAL();
            IList<CiudadDTO> ciudades = ciudadDAL.CiudadLeer(idDpto);
            return ciudades;
        }

    }
}
