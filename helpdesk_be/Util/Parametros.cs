namespace helpdesk_be.Util
{
    public class Parametros
    {
        public string LeerPropiedadesConfiguracion(string key)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");

            var config = configuration.Build();
            var rutaAlmacenamiento = config[key];
            return rutaAlmacenamiento;
        }
    }

    
}
