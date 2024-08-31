namespace helpdesk_be.Models
{
    public class GraficosDTO
    {
        public string Encabezado { get; set; }
        public int Cantidad { get; set; }
        public GraficosDTO(string encabezado, int cantidad)
        {
            Encabezado = encabezado;
            Cantidad = cantidad;
        }

        public GraficosDTO()
        {
        }
    }
}
