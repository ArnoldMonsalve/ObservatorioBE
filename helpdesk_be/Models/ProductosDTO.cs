namespace helpdesk_be.Models
{
    public class ProductosDTO
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdCategoriaProducto { get; set; }
        public string Fabricante { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaActualizacion { get; set; }


        public ProductosDTO(int id, string nombre,int idcategoriaproducto, string fabricante, string descripcion, DateTime fechaRegistro, int idUsuario, DateTime fechaActualizacion)
        {
            Id = id;
            Nombre = nombre;
            IdCategoriaProducto = idcategoriaproducto;
            Fabricante = fabricante;
            Descripcion = descripcion;
            FechaRegistro = fechaRegistro;
            IdUsuario = idUsuario;
            FechaActualizacion = fechaActualizacion;
        }
        public ProductosDTO()
        {
        }
    }
}
