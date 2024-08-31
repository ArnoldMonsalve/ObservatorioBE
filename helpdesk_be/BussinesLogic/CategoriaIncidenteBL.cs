using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class CategoriaIncidenteBL
    {
        public CategoriaIncidenteBL()
        {

        }

        public IList<CategoriaIncidenteDTO> CategoriaIncidenteLeer(int? id)
        {
            CategoriaIncidenteDAL CategoriaIncidenteDAL = new CategoriaIncidenteDAL();
            IList<CategoriaIncidenteDTO> CategoriaIncidentes = CategoriaIncidenteDAL.CategoriaIncidenteLeer(id);
            return CategoriaIncidentes;
        }

        public bool CategoriaIncidenteCrear(CategoriaIncidenteDTO CategoriaIncidente)
        {
            CategoriaIncidenteDAL CategoriaIncidenteDAL = new CategoriaIncidenteDAL();
            DateTime fechaActual = DateTime.Now; //Consigue la fecha-hora actual
            CategoriaIncidente.FechaRegistro = fechaActual;
            CategoriaIncidente.FechaActualizacion = fechaActual;
            bool exitoso = CategoriaIncidenteDAL.CategoriaIncidenteCrear(CategoriaIncidente);
            return exitoso;
        }

        public bool CategoriaIncidenteActualizar(CategoriaIncidenteDTO CategoriaIncidente)
        {
            CategoriaIncidenteDAL CategoriaIncidenteDAL = new CategoriaIncidenteDAL();
            CategoriaIncidente.FechaActualizacion = DateTime.Now;
            bool exitoso = CategoriaIncidenteDAL.CategoriaIncidenteActualizar(CategoriaIncidente);
            return exitoso;
        }

        public bool CategoriaIncidenteBorrar(int id)
        {
            CategoriaIncidenteDAL CategoriaIncidenteDAL = new CategoriaIncidenteDAL();
            bool exitoso = CategoriaIncidenteDAL.CategoriaIncidenteBorrar(id);
            return exitoso;
        }
    }
}
