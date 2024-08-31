using helpdesk_be.Models;
using helpdesk_be.DataAccessLogic;

namespace helpdesk_be.BussinesLogic
{
    public class DepartamentoBL
    {
        public DepartamentoBL()
        {

        }

        public IList<DepartamentoDTO> DepartamentoLeer()
        {
            DepartamentoDAL departamentoDAL = new DepartamentoDAL();
            IList<DepartamentoDTO> departamentos = departamentoDAL.DepartamentoLeer();
            return departamentos;
        }
    }
}
