using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;


namespace helpdesk_be.BussinesLogic
{
    public class GraficasBL
    {
        public GraficasBL()
        {

        }

        public IList<GraficosDTO> GraficasLeer(int Opcion)
        {
            GraficasDAL GraficasDAL = new GraficasDAL();
            IList<GraficosDTO> Graficass = GraficasDAL.graficaLeer(Opcion);
            return Graficass;
        }
    }
}
