using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class IncidenteBL
    {
        public IncidenteBL()
        {

        }

        public IList<IncidenteDTO> IncidenteLeer(int? id)
        {
            IncidenteDAL IncidenteDAL = new IncidenteDAL();
            IList<IncidenteDTO> Incidentes = IncidenteDAL.IncidenteLeer(id);
            return Incidentes;
        }

        public bool IncidenteCrear(IncidenteDTO Incidente)
        {
            IncidenteDAL IncidenteDAL = new IncidenteDAL();
            DateTime fechaActual = DateTime.Now;
            Incidente.FechaActualizacion = fechaActual;
            bool exitoso = IncidenteDAL.IncidenteCrear(Incidente);
            return exitoso;
        }

        public bool IncidenteActualizar(IncidenteDTO Incidente)
        {
            IncidenteDAL IncidenteDAL = new IncidenteDAL();
            Incidente.FechaActualizacion = DateTime.Now;
            bool exitoso = IncidenteDAL.IncidenteActualizar(Incidente);
            return exitoso;
        }

        public bool IncidenteBorrar(int id)
        {
            IncidenteDAL IncidenteDAL = new IncidenteDAL();
            bool exitoso = IncidenteDAL.IncidenteBorrar(id);
            return exitoso;
        }
    }
}
