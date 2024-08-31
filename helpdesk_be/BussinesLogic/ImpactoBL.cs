using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class ImpactoBL
    {
        public ImpactoBL()
        {

        }

        public IList<ImpactoDTO> ImpactoLeer(int? id)
        {
            ImpactoDAL impactoDAL = new ImpactoDAL();
            IList<ImpactoDTO> impactos = impactoDAL.ImpactoLeer(id);
            return impactos;
        }

        public bool ImpactoCrear(ImpactoDTO impacto)
        {
            ImpactoDAL impactoDAL = new ImpactoDAL();
            DateTime fechaActual = DateTime.Now; //Consigue la fecha-hora actual
            impacto.FechaRegistro = fechaActual;
            impacto.FechaActualizacion = fechaActual;
            bool exitoso = impactoDAL.ImpactoCrear(impacto);
            return exitoso;
        }

        public bool ImpactoActualizar(ImpactoDTO impacto)
        {
            ImpactoDAL impactoDAL = new ImpactoDAL();
            impacto.FechaActualizacion = DateTime.Now;
            bool exitoso = impactoDAL.ImpactoActualizar(impacto);
            return exitoso;
        }

        public bool ImpactoBorrar(int id)
        {
            ImpactoDAL impactoDAL = new ImpactoDAL();
            bool exitoso = impactoDAL.ImpactoBorrar(id);
            return exitoso;
        }
    }
}
