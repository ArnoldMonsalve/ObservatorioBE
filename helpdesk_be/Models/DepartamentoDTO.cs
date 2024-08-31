namespace helpdesk_be.Models
{
    public class DepartamentoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public DepartamentoDTO(int id, string nombre, DateTime fechaRegistro, int idUsuario, DateTime fechaActualizacion)
        {
            Id = id;
            Nombre = nombre;
            FechaRegistro = fechaRegistro;
            IdUsuario = idUsuario;
            FechaActualizacion = fechaActualizacion;
        }

        public DepartamentoDTO()
        {

        }
    }
}
