namespace helpdesk_be.Models
{
    public class LoginDTO
    {
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public int IdEntidad { get; set; }
        public LoginDTO (int idRol, string nombreRol, string correo, string clave, int id, string nombre, int idEntidad)
        {
            IdRol = idRol;
            NombreRol = nombreRol;
            Correo = correo;
            Clave = clave;
            Id = id;
            Nombre = nombre;
            IdEntidad = idEntidad;
        }

        public LoginDTO()
        {

        }
    }
}
