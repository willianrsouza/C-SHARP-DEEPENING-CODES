using System;

namespace FormatacaoDateTime
{
    class Program
    {
        static void Main(string[] args)
        {


            #region DateTime Formatação

            DateTime now = DateTime.Now;

            var formats = new string[] {"d", "D", "f", "F", "G",
                "m", "o", "r", "T", "u", "V"};

            foreach (var format in formats)
            {
                Console.WriteLine("Data no formato {0}: {1}", format, now.ToString(format));
                //Console.WriteLine($"Data no formato {format}: {now.ToString(format)} ");
            }

            Console.WriteLine($"Data no Formato d: {now:d} ");
            Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy} ");

            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

            Console.ReadKey();

            #endregion


        }
    }
}
