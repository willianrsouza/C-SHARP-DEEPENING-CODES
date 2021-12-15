using System;

namespace TrabalhandoComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime
            /* Buscar Data atual */
            var now = DateTime.Now;

            var today = DateTime.Today;

            /* Buscar Data três dias atrás */
            var treeDaysAgo = now.AddDays(-3);

            /* Data de experiação, por meses */
            var sixMonthsLater = today.AddMonths(6);

            /* Data de experiação de dois anos*/
            var twoYearsLater = today.AddYears(2);

            /* Opções de visualização/formatação utilizando data*/
            var shortDate = now.ToShortDateString();
            var longDate = now.ToLongDateString();

            var shortTime = now.ToShortTimeString();
            var longTime = now.ToLongTimeString();

            var date = now.Date;
            var day = now.Day;
            var month = now.Day;
            var year = now.Day;
            var hour = now.Day;
            var minute = now.Day;
            var second = now.Day;

            /* Comparando as datas*/
            var dayOfWeek = now.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("É fim de Semana.");
            }

            /* Data do Ano*/
            var dayofYear = now.DayOfYear;

            #endregion DateTime

            Console.ReadKey();
        }
    }
}
