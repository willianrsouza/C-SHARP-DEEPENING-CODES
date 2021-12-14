using System;

namespace PrincipaisMetodosBuscaString
{
    class Program
    {
        static void Main(string[] args)
        {
            var frase = " C# é uma linguagem moderna e versátil." +
                "Com C# consigo desenvolver para Web, Desktop, Jogos," +
                "Mobile, entre outros. ";

            /*IndexOf*/
            var IndexOf = frase.IndexOf("C#");

            /*LastIndexOf*/
            var LastIndexOf = frase.LastIndexOf("C#");

            /*StartWith*/
            var startWith = frase.StartsWith("C#");

            /*Substring*/
            var IndexOfMobile = frase.IndexOf("Mobile");
            var substring = frase.Substring(IndexOfMobile, 6);

            /*Contains*/
            var containsOrdinal = frase.Contains("C#", StringComparison.OrdinalIgnoreCase);
            var contains = frase.Contains("C#");

            Console.ReadKey();
        }
    }
}
