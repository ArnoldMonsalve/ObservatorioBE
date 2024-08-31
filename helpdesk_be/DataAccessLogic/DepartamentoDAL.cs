using helpdesk_be.Util;
using Microsoft.Data.SqlClient;
using helpdesk_be.Models;

namespace helpdesk_be.DataAccessLogic
{
    public class DepartamentoDAL
    {
        //Leer DepartamentoDTO        
        public IList<DepartamentoDTO> DepartamentoLeer()
        {
            IList<DepartamentoDTO> departamentos = new List<DepartamentoDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM DEPARTAMENTO ORDER BY NOMBRE";

                SqlCommand command = new SqlCommand(sql, con.conectar());
                using (SqlDataReader reader = command.ExecuteReader())

                    while (reader.Read())
                    {
                        DepartamentoDTO departamento = new DepartamentoDTO();
                        departamento.Id = reader.GetInt32(0);
                        departamento.Nombre = reader.GetString(1);      

                        departamentos.Add(departamento);

                    }

                con.desconectar();
                return departamentos;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return departamentos;
        }
    }
}
