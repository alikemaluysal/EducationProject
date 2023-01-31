namespace Framework.Services.Basic
{
    public class NameService
    {
        public static string CharacterRegulator(string name)
        {
            name.Replace("\"", "")
                 .Replace("!", "")
                 .Replace("'", "")
                 .Replace("^", "")
                 .Replace("+", "")
                 .Replace("%", "")
                 .Replace("&", "")
                 .Replace("/", "")
                 .Replace("(", "")
                 .Replace(")", "")
                 .Replace("=", "")
                 .Replace("?", "")
                 .Replace("_", "")
                 .Replace(" ", "-")
                 .Replace("@", "")
                 .Replace("€", "")
                 .Replace("¨", "")
                 .Replace("~", "")
                 .Replace(",", "")
                 .Replace(";", "")
                 .Replace(":", "")
                 .Replace(".", "-")
                 .Replace("Ö", "o")
                 .Replace("ö", "o")
                 .Replace("Ü", "u")
                 .Replace("ü", "u")
                 .Replace("ı", "i")
                 .Replace("İ", "i")
                 .Replace("ğ", "g")
                 .Replace("Ğ", "g")
                 .Replace("æ", "")
                 .Replace("ß", "")
                 .Replace("â", "a")
                 .Replace("î", "i")
                 .Replace("ş", "s")
                 .Replace("Ş", "s")
                 .Replace("Ç", "c")
                 .Replace("ç", "c")
                 .Replace("<", "")
                 .Replace(">", "")
                 .Replace("|", "");
            return name;
        }
    }
}