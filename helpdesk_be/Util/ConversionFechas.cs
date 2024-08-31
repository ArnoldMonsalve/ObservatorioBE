namespace helpdesk_be.Util
{
    public class ConversionFechas
    {
        public string ConversionDeFechas(DateTime fecha)
        {
            string anioRegistro = fecha.Year.ToString();
            int mesRegistro = fecha.Month;
            int diaRegistro = fecha.Day;
            int horaRegistro = fecha.Hour;
            int minutosRegistro = fecha.Minute;
            int segundosRegistro = fecha.Second;

            string fechaRegistro = anioRegistro + "-" + (mesRegistro < 10 ? "0" + mesRegistro.ToString() : mesRegistro.ToString()) + "-" + (diaRegistro < 10 ? "0" + diaRegistro.ToString() : diaRegistro.ToString()) + " " + (horaRegistro < 10 ? "0" + horaRegistro.ToString() : horaRegistro.ToString()) + ":" + (minutosRegistro < 10 ? "0" + minutosRegistro.ToString() : minutosRegistro.ToString()) + ":" + (segundosRegistro < 10 ? "0" + segundosRegistro.ToString() : segundosRegistro.ToString());

            return fechaRegistro;

        }
    }
}
