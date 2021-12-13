using System;

namespace PrincipaisMetodosString
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Principais Metodos - String

            var frase = " C# é uma linguagem moderna e versátil." +
                "Com C# consigo desenvolver para Web, Desktop, Jogos," +
                "Mobile, entre outros. ";

            /*Length*/
            var tamanho = frase.Length;

            /*Empty*/
            var vazio = string.Empty;

            /*Tolower, To Upper*/
            var paragradoMinusculo = frase.ToLower();
            var paragradoMaisculo = frase.ToUpper();

            /*Split*/
            var frases = frase.Split('.');

            /*Trim, TrimEnd, TrimStart*/
            var paragrafoTrim = frase.Trim();
            var paragrafoTrimEnd = frase.TrimEnd();
            var paragrafoTrimStart = frase.TrimStart();

            /*IsNullOrWhiteSpace*/
            var isNullOrWhiteSpace = string.IsNullOrEmpty(frase);

            /*Replace*/
            var paragrafoCsharp = frase.Replace("C#", "C-Sharp");

            Console.ReadKey();

            #endregion
        }
    }
}
