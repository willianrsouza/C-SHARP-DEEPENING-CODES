using System;

namespace ConversoesOperadores
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Conversões

            /* Base */
            int notaAluno = 10;

            /* Conversão Implicita */
            double notaAlunoDouble = notaAluno;

            /* Conversão Explicita*/
            int numeroDoubleParaInt = (int)notaAlunoDouble;

            /* Utilizando Convert*/
            string notaString = "10";
            int notaConvert = Convert.ToInt32(notaString);

            /* Utilizando Convert*/
            int notaParse = int.Parse(notaString);

            if (int.TryParse(notaString, out int notaTryParse))
            {
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            #endregion

            Console.Read();
        }
    }
}
