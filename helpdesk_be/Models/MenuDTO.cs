namespace helpdesk_be.Models
{
    public class MenuDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descrípcion { get; set; }
        public string Url { get; set; }
        public int Orden { get; set; }

        public MenuDTO()
        {
    
        }

        public MenuDTO(int id, string nombre, string descripcion, string url, int orden)
        {
            Id = id;
            Nombre = nombre;
            Descrípcion = descripcion;
            Url = url;
            Orden = orden;
        }

    }

}
