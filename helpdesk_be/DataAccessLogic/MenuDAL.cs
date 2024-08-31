using helpdesk_be.Util;
using Microsoft.Data.SqlClient;
using helpdesk_be.Models;

namespace helpdesk_be.DataAccessLogic
{
    public class MenuDAL
    {
        public IList<MenuDTO> MenuLeerRol(int? idRol)
        {
            IList<MenuDTO> menus = new List<MenuDTO>();
            try
            {
                Conexion con = new Conexion();
                string sql = $"EXEC SP_MENU_ROL "
                                + $"@ROLID = {idRol}";

                SqlCommand command = new SqlCommand(sql, con.conectar());

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        MenuDTO menu = new MenuDTO();
                        menu.Id = reader.GetInt32(0);
                        menu.Nombre = reader.GetString(1);
                        menu.Descrípcion = reader.GetString(2);
                        menu.Url = reader.GetString(3);
                        menu.Orden = reader.GetInt32(4);
                        menus.Add(menu);

                    }
                con.desconectar();
                
            }

            catch (SqlException e)
            {
                throw e;
            }
            return menus;
        }
    }
}
