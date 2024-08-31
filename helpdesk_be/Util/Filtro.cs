namespace helpdesk_be.Util
{
    public static  class Filtro
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove)
            {
                if (c=='ó')
                {
                    str = str.Replace(c, 'o');

                }else if (c == 'Ó')
                {
                    str = str.Replace(c, 'o');
                }
                else if (c == 'í')
                {
                    str = str.Replace(c, 'i');
                }
                else if (c == 'á')
                {
                    str = str.Replace(c, 'a');
                }
                else
                {
                    str = str.Replace(c.ToString(), String.Empty);
                }
            }

            return str;
        }
    }
}
