namespace helpdesk_be.Models
{
    public class ImpactoDTO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public ImpactoDTO(int id, string nombre, string descripcion, DateTime fechaRegistro, int idUsuario, DateTime fechaActualizacion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            FechaRegistro = fechaRegistro;
            IdUsuario = idUsuario;
            FechaActualizacion = fechaActualizacion;
        }
        public ImpactoDTO()
        {
        }
    }
}
