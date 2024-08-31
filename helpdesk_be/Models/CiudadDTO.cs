namespace helpdesk_be.Models
{
    public class CiudadDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public CiudadDTO (int id, string nombre, int idDepartamento, DateTime fechaRegistro, int idUsuario, DateTime fechaActualizacion)
        {
            Id = id;
            Nombre = nombre;
            IdDepartamento = idDepartamento;
            FechaRegistro = fechaRegistro;
            IdUsuario = idUsuario;
            FechaActualizacion = fechaActualizacion;
        }

        public CiudadDTO()
        {
        }
    }
}
