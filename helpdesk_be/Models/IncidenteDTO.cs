namespace helpdesk_be.Models
{
    public class IncidenteDTO
    {

        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdImpacto { get; set; }
        public int IdProducto { get; set; }
        public string MedidasTomadas { get; set; }
        public int IdDepartamento { get; set; }
        public int IdMunicipio { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public IncidenteDTO(int id, int idCategoria, DateTime fecha, string descripcion, int idImpacto, int idProducto, string medidasTomadas, int idDepartamento, int idMunicipio, int idUsuario, DateTime fechaActualizacion)
        {
            Id = id;
            IdCategoria = idCategoria;
            Fecha = fecha;
            Descripcion = descripcion;
            IdImpacto = idImpacto;
            IdProducto = idProducto;
            MedidasTomadas = medidasTomadas;
            IdDepartamento = idDepartamento;
            IdMunicipio = idMunicipio;
            IdUsuario = idUsuario;
            FechaActualizacion = fechaActualizacion;
        }
        public IncidenteDTO()
        {
        }
    }
}
